alter session set "_ORACLE_SCRIPT"=true;
-- Tạo các USER quan trọng

CREATE USER DAPH_ADMIN IDENTIFIED BY daph_admin;
GRANT SYSDBA TO DAPH_ADMIN;


CREATE USER DAPH_ADMIN1 IDENTIFIED BY daph_admin1;
GRANT EXECUTE ANY PROCEDURE TO DAPH_ADMIN1;
GRANT CREATE ROLE TO DAPH_ADMIN1;
GRANT CREATE USER TO DAPH_ADMIN1;
GRANT CREATE SESSION TO DAPH_ADMIN1;
GRANT CREATE TABLE TO DAPH_ADMIN1;
GRANT RESOURCE TO DAPH_ADMIN1;
GRANT UNLIMITED TABLESPACE TO DAPH_ADMIN1;
GRANT CREATE VIEW TO DAPH_ADMIN1;
GRANT CREATE TRIGGER TO DAPH_ADMIN1;
GRANT CREATE PROCEDURE TO DAPH_ADMIN1;
GRANT EXECUTE ON DBMS_RLS TO DAPH_ADMIN1;
GRANT CREATE ANY CONTEXT TO DAPH_ADMIN1;
GRANT CREATE PUBLIC SYNONYM TO DAPH_ADMIN1;
GRANT AUDIT SYSTEM TO DAPH_ADMIN1;
GRANT EXECUTE ON DBMS_FGA TO DAPH_ADMIN1;

-- Tạo các ROLE
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
CREATE ROLE DAPH_NHANVIENCOBAN;
CREATE ROLE DAPH_GIANGVIEN;
CREATE ROLE DAPH_GIAOVU;
CREATE ROLE DAPH_TRUONGDONVI;
CREATE ROLE DAPH_TRUONGKHOA;

-- Tạo các USER trong bảng NHANSU
-- Nhân viên cơ bản
CREATE USER DAPH_NV01 IDENTIFIED BY NV01;
GRANT DAPH_NHANVIENCOBAN TO DAPH_NV01;

CREATE USER DAPH_NV02 IDENTIFIED BY NV02;
GRANT DAPH_NHANVIENCOBAN TO DAPH_NV02;

CREATE USER DAPH_NV03 IDENTIFIED BY NV03;
GRANT DAPH_NHANVIENCOBAN TO DAPH_NV03;

-- Giáo viên
CREATE USER DAPH_GVI01 IDENTIFIED BY GVI01;
GRANT DAPH_GIANGVIEN TO DAPH_GVI01;

CREATE USER DAPH_GVI02 IDENTIFIED BY GVI02;
GRANT DAPH_GIANGVIEN TO DAPH_GVI02;

CREATE USER DAPH_GVI03 IDENTIFIED BY GVI03;
GRANT DAPH_GIANGVIEN TO DAPH_GVI03;

-- Giáo vụ
CREATE USER DAPH_GVU01 IDENTIFIED BY GVU01;
GRANT DAPH_GIAOVU TO DAPH_GVU01;

CREATE USER DAPH_GVU02 IDENTIFIED BY GVU02;
GRANT DAPH_GIAOVU TO DAPH_GVU02;

CREATE USER DAPH_GVU03 IDENTIFIED BY GVU03;
GRANT DAPH_GIAOVU TO DAPH_GVU03;

-- Trưởng đơn vị
CREATE USER DAPH_TDV01 IDENTIFIED BY TDV01;
GRANT DAPH_TRUONGDONVI TO DAPH_TDV01;

CREATE USER DAPH_TDV02 IDENTIFIED BY TDV02;
GRANT DAPH_TRUONGDONVI TO DAPH_TDV02;

CREATE USER DAPH_TDV03 IDENTIFIED BY TDV03;
GRANT DAPH_TRUONGDONVI TO DAPH_TDV03;

-- Trưởng khoa
CREATE USER DAPH_TK01 IDENTIFIED BY TK01;
GRANT DAPH_TRUONGKHOA TO DAPH_TK01;

CREATE USER DAPH_TK02 IDENTIFIED BY TK02;
GRANT DAPH_TRUONGKHOA TO DAPH_TK02;

CREATE USER DAPH_TK03 IDENTIFIED BY TK03;
GRANT DAPH_TRUONGKHOA TO DAPH_TK03;


-- Tao cac USER trong bang SINHVIEN
CREATE USER DAPH_SV21120206 IDENTIFIED BY SV21120206;
EXEC DAPH_ADMIN1.gan_quyen_sinh_vien('DAPH_SV21120206');

CREATE USER DAPH_SV21120251 IDENTIFIED BY SV21120251;
EXEC gan_quyen_sinh_vien('DAPH_SV21120251');

CREATE USER DAPH_SV21120289 IDENTIFIED BY SV21120289;
EXEC gan_quyen_sinh_vien('DAPH_SV21120289');

CREATE USER DAPH_SV21120445 IDENTIFIED BY SV21120445;
EXEC gan_quyen_sinh_vien('DAPH_SV21120445');

CREATE USER DAPH_SV21120446 IDENTIFIED BY SV21120446;
EXEC gan_quyen_sinh_vien('DAPH_SV21120446');

CREATE USER DAPH_SV21120447 IDENTIFIED BY SV21120447;
EXEC gan_quyen_sinh_vien('DAPH_SV21120447');

CREATE USER DAPH_SV21120448 IDENTIFIED BY SV21120448;
EXEC gan_quyen_sinh_vien('DAPH_SV21120448');

CREATE USER DAPH_SV21120449 IDENTIFIED BY SV21120449;
EXEC gan_quyen_sinh_vien('DAPH_SV21120449');

CREATE USER DAPH_SV21120450 IDENTIFIED BY SV21120450;
EXEC gan_quyen_sinh_vien('DAPH_SV21120450');

CREATE USER DAPH_SV21120451 IDENTIFIED BY SV21120451;
EXEC gan_quyen_sinh_vien('DAPH_SV21120451');