-- Tạo các CONTEXT cần thiết để sử dụng

-- Context để sử dụng cho việc lấy thông tin cá nhân của sinh viên
CREATE CONTEXT USER_SINHVIEN_CONTEXT USING DAPH_ADMIN1.USER_SINHVIEN_context_package;
-- Tạo package để lấy thông tin
CREATE OR REPLACE PACKAGE USER_SINHVIEN_context_package AS
    --lấy chương trình đào tạo sinh viên theo học
    PROCEDURE MACT_CONTEXT;
END;
/
CREATE OR REPLACE PACKAGE BODY USER_SINHVIEN_context_package AS
    PROCEDURE MACT_CONTEXT AS
        p_mact VARCHAR2 (20);
    BEGIN
        SELECT MACT INTO p_mact
        FROM DAPH_ADMIN1.DAPH_SINHVIEN
        WHERE MASV = SYS_CONTEXT('USERENV', 'SESSION_USER');
        DBMS_SESSION.SET_CONTEXT('USER_SINHVIEN_CONTEXT', 'MACT', p_mact);
        EXCEPTION
            WHEN NO_DATA_FOUND THEN NULL;
    END MACT_CONTEXT;
END USER_SINHVIEN_context_package;
/


-- Cho mọi user đều có package này 
GRANT EXECUTE ON DAPH_ADMIN1.USER_SINHVIEN_context_package TO PUBLIC;
CREATE PUBLIC SYNONYM USER_SINHVIEN_context_package FOR DAPH_ADMIN1.USER_SINHVIEN_context_package;


-- Tạo trigger khi login bằng người dùng SYS
CONNECT DAPH_ADMIN/daph_admin@localhost AS SYSDBA;
alter session set "_ORACLE_SCRIPT"=true;
CREATE OR REPLACE TRIGGER USER_SINHVIEN_context_package_trigger
AFTER LOGON ON DATABASE
BEGIN
  DAPH_ADMIN1.USER_SINHVIEN_context_package.MACT_CONTEXT;
END;
/


CONNECT DAPH_ADMIN1/daph_admin1@localhost;
-- Tạo package chứa các function ràng buộc, quy định đói với việc truy cập, cập nhật dữ liệu của người dùng
-- Cho các user chỉ được thao tác đối với những sinh viên có mã trong context USER_SINHVIEN_CONTEXT
CREATE OR REPLACE PACKAGE security_package AS
    FUNCTION user_data_security_masv(owner VARCHAR2, objname VARCHAR2)
        RETURN VARCHAR2;
        
    FUNCTION user_data_security_mact(owner VARCHAR2, objname VARCHAR2)
        RETURN VARCHAR2;
END security_package;
/
CREATE OR REPLACE PACKAGE BODY security_package AS
    FUNCTION user_data_security_masv(owner VARCHAR2, objname VARCHAR2) RETURN VARCHAR2 AS
        predicate VARCHAR2(2000);
        checker VARCHAR2(100);
    BEGIN
        predicate := '1=2';
        checker := SYS_CONTEXT('USERENV','SESSION_USER');
        -- đối với người dùng là sinh viên
        IF INSTR(checker, 'DAPH_SV') > 0 THEN
            predicate := 'MASV = SYS_CONTEXT(''USERENV'',''SESSION_USER'')';
        ELSE 
            predicate := NULL;
        END IF;
        RETURN predicate;
    END user_data_security_masv;
    
    FUNCTION user_data_security_mact(owner VARCHAR2, objname VARCHAR2) RETURN VARCHAR2 AS
        predicate VARCHAR2(2000);
        checker VARCHAR2(100);
    BEGIN
        predicate := '1=2';
        checker := SYS_CONTEXT('USERENV','SESSION_USER');
        -- đối với người dùng là sinh viên
        IF INSTR(checker, 'DAPH_SV') > 0 THEN
            predicate := 'MACT = SYS_CONTEXT(''USER_SINHVIEN_CONTEXT'',''MACT'')';
        ELSE 
            predicate := NULL;
        END IF;
        RETURN predicate;
    END user_data_security_mact;
END security_package;
/

GRANT EXECUTE ON DAPH_ADMIN1.security_package TO PUBLIC;
CREATE PUBLIC SYNONYM security_package FOR DAPH_ADMIN1.security_package;


-- Thực hiện VPD
BEGIN
-- Xem thông tin cá nhân của sinh viên 
    DBMS_RLS.add_policy('DAPH_ADMIN1', 'DAPH_SINHVIEN', 'DAPH_SINHVIEN_SELECT_POLICY', 
                        'DAPH_ADMIN1', 'SECURITY_PACKAGE.USER_DATA_SECURITY_MASV', 
                        'SELECT');
END;
/

-- Cập nhật địa chỉ và điện thoại của chính mình 
BEGIN
    DBMS_RLS.add_policy(OBJECT_SCHEMA => 'DAPH_ADMIN1',
                        OBJECT_NAME => 'DAPH_SINHVIEN',
                        POLICY_NAME => 'DAPH_SINHVIEN_UPDATE_POLICY',
                        FUNCTION_SCHEMA => 'DAPH_ADMIN1',
                        POLICY_FUNCTION => 'SECURITY_PACKAGE.USER_DATA_SECURITY_MASV', 
                        STATEMENT_TYPES => 'UPDATE',
                        SEC_RELEVANT_COLS => 'DCHI, DT',
                        UPDATE_CHECK => TRUE);
END;
/

-- Xem thông tin khóa học mở mà chương trình đào tạo sinh viên theo học
BEGIN
    DBMS_RLS.add_policy('DAPH_ADMIN1', 'DAPH_KHMO', 'DAPH_KHMO_SELECT_POLICY', 
                        'DAPH_ADMIN1', 'SECURITY_PACKAGE.USER_DATA_SECURITY_MACT', 
                        'SELECT');
END;
/

-- Xem danh sách học phần mà chương trình đào tạo sinh viên theo học
BEGIN
    DBMS_RLS.add_policy('DAPH_ADMIN1', 'DAPH_HOCPHAN', 'DAPH_HOCPHAN_SELECT_POLICY', 
                        'DAPH_ADMIN1', 'SECURITY_PACKAGE.USER_DATA_SECURITY_MACT', 
                        'SELECT');
END;
/

-- Xem thông tin đăng ký liên quan đến sinh viên
BEGIN
    DBMS_RLS.add_policy('DAPH_ADMIN1', 'DAPH_DANGKY', 'DAPH_DANGKY_SELECT_POLICY', 
                        'DAPH_ADMIN1', 'SECURITY_PACKAGE.USER_DATA_SECURITY_MASV', 
                        'SELECT');
END;
/

-- Xem thông tin học phần đang đăng kỳ ở kỳ hiện tại của sinh viên, học phần này cần được duyệt để thêm vào bảng DAPH_DANGKY
BEGIN
    DBMS_RLS.add_policy('DAPH_ADMIN1', 'DAPH_DANGKY_SV', 'DAPH_DANGKY_SV_POLICY', 
                        'DAPH_ADMIN1', 'SECURITY_PACKAGE.USER_DATA_SECURITY_MASV', 
                        'SELECT, INSERT, DELETE', TRUE);
END;
/