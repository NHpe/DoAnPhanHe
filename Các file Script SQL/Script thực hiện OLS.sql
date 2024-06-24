alter session set "_ORACLE_SCRIPT"=true;


-- Execute using SYSDBA privileges
-- Check for OLS status
SELECT STATUS FROM DBA_OLS_STATUS WHERE NAME = 'OLS_CONFIGURE_STATUS';


-- Run these 2 lines separately in order
BEGIN LBACSYS.CONFIGURE_OLS; END;-- This procedure registers Oracle Label Security
/

BEGIN LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS; END; -- This procedure enables it
/

-- Restart the database
SHUTDOWN IMMEDIATE;
STARTUP;

-- Enable LBACSYS account
ALTER USER LBACSYS ACCOUNT UNLOCK IDENTIFIED BY 0;
/

-- Execute these line after setting up OLS and/or after starting 
ALTER PLUGGABLE DATABASE XEPDB1 OPEN READ WRITE;

ALTER SESSION SET CONTAINER = XEPDB1;
SHOW CON_NAME;

-- Create and grant privileges to OLS management role
DROP USER OLS_MANAGER CASCADE;

CREATE USER OLS_MANAGER IDENTIFIED BY olsmanager123 CONTAINER = CURRENT;

GRANT EXECUTE ON LBACSYS.LBAC_SYSDBA TO OLS_MANAGER;
GRANT CREATE SESSION TO OLS_MANAGER;
GRANT CREATE TABLE TO OLS_MANAGER;
GRANT CREATE PROCEDURE TO OLS_MANAGER;

GRANT CONNECT,RESOURCE TO OLS_MANAGER;
GRANT UNLIMITED TABLESPACE TO OLS_MANAGER;
GRANT SELECT ANY DICTIONARY TO OLS_MANAGER;

GRANT EXECUTE ON LBACSYS.SA_COMPONENTS TO OLS_MANAGER WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.sa_user_admin TO OLS_MANAGER WITH GRANT OPTION;
GRANT EXECUTE ON LBACSYS.sa_label_admin TO OLS_MANAGER WITH GRANT OPTION;
GRANT EXECUTE ON sa_policy_admin TO OLS_MANAGER WITH GRANT OPTION;
GRANT EXECUTE ON char_to_label TO OLS_MANAGER WITH GRANT OPTION; 

GRANT LBAC_DBA TO OLS_MANAGER;
GRANT EXECUTE ON sa_sysdba TO OLS_MANAGER;
GRANT EXECUTE ON TO_LBAC_DATA_LABEL TO OLS_MANAGER; -- C?P QUY?N TH?C THI 
GRANT EXECUTE ON LBACSYS.CONFIGURE_OLS TO OLS_MANAGER;
GRANT EXECUTE ON LBACSYS.OLS_ENFORCEMENT TO OLS_MANAGER;

GRANT DBA TO OLS_MANAGER;
GRANT CONNECT TO OLS_MANAGER WITH ADMIN OPTION;
GRANT EXECUTE ANY PROCEDURE TO OLS_MANAGER;
GRANT CREATE USER TO OLS_MANAGER;

-- Execute using LBACSYS privileges/OLS_MANAGER account
-- Drop policy
--exec sa_sysdba.drop_policy('notification_ols_pol',TRUE);
--/

-- Create policy
EXEC sa_sysdba.create_policy(policy_name => 'notification_ols_pol', column_name => 'ols_col');
/

-- Create Label Level
EXEC sa_components.create_level(policy_name => 'notification_ols_pol', level_num => 10, short_name => 'SV', long_name => 'SINHVIEN');
EXEC sa_components.create_level(policy_name => 'notification_ols_pol', level_num => 20, short_name => 'NV', long_name => 'NHANVIEN');
EXEC sa_components.create_level(policy_name => 'notification_ols_pol', level_num => 30, short_name => 'GVu', long_name => 'GIAOVU');
EXEC sa_components.create_level(policy_name => 'notification_ols_pol', level_num => 40, short_name => 'GVi', long_name => 'GIANGVIEN');
EXEC sa_components.create_level(policy_name => 'notification_ols_pol', level_num => 50, short_name => 'TDV', long_name => 'TRUONGDONVI');
EXEC sa_components.create_level(policy_name => 'notification_ols_pol', level_num => 60, short_name => 'TK', long_name => 'TRUONGKHOA');

-- Create Label Compartment
EXEC sa_components.create_compartment(policy_name => 'notification_ols_pol',comp_num => '10', short_name => 'HTTT', long_name => 'He Thong Thong Tin');
EXEC sa_components.create_compartment(policy_name => 'notification_ols_pol',comp_num => '20', short_name => 'CNPM', long_name => 'Cong Nghe Phan Mem');
EXEC sa_components.create_compartment(policy_name => 'notification_ols_pol',comp_num => '30', short_name => 'KHMT', long_name => 'Khoa Hoc May Tinh');
EXEC sa_components.create_compartment(policy_name => 'notification_ols_pol',comp_num => '40', short_name => 'CNTT', long_name => 'Cong Nghe Thong Tin');
EXEC sa_components.create_compartment(policy_name => 'notification_ols_pol',comp_num => '50', short_name => 'TGMT', long_name => 'Thi Giac May Tinh');
EXEC sa_components.create_compartment(policy_name => 'notification_ols_pol',comp_num => '60', short_name => 'MMT', long_name => 'Mang May Tinh');

-- Create Label Group
EXEC sa_components.create_group(policy_name => 'notification_ols_pol', group_num => 100, short_name => 'CS1', long_name => 'Co So 1');
EXEC sa_components.create_group(policy_name => 'notification_ols_pol', group_num => 200, short_name => 'CS2', long_name => 'Co So 2');

-- Apply policy to table
begin
sa_policy_admin.apply_table_policy
(policy_name => 'notification_ols_pol',
schema_name => 'OLS_MANAGER',
table_name => 'DAPH_THONGBAO',
table_options => 'NO_CONTROL');
end;
/

-- Create label
EXEC sa_label_admin.create_label('notification_ols_pol', 1000, 'TK');
/
EXEC sa_label_admin.create_label('notification_ols_pol', 1100, 'TDV:CS2');
/
EXEC sa_label_admin.create_label('notification_ols_pol', 1200, 'GVi:HTTT:CS2');
/
EXEC sa_label_admin.create_label('notification_ols_pol', 1300, 'Gvu:CS1');
/
EXEC sa_label_admin.create_label('notification_ols_pol', 1400, 'SV:CS2');
/


-- Apply label to columns
UPDATE DAPH_THONGBAO
SET ols_label = char_to_label('notification_ols_pol', 'TK')
WHERE CHUCVU >= 6;

UPDATE DAPH_THONGBAO
SET ols_label = char_to_label('notification_ols_pol', 'TDV:CS2')
WHERE CHUCVU >= 5 AND COSO = 2;

UPDATE DAPH_THONGBAO
SET ols_label = char_to_label('notification_ols_pol', 'Gvu:CS1')
WHERE CHUCVU >= 3 AND COSO = 1;

UPDATE DAPH_THONGBAO
SET ols_label = char_to_label('notification_ols_pol', 'Gvi:HTTT:CS2')
WHERE CHUCVU >= 4 AND NGANH = 1 AND COSO = 2;

UPDATE DAPH_THONGBAO
SET ols_label = char_to_label('notification_ols_pol', 'SV:CS2')
WHERE CHUCVU >= 1 AND COSO = 2;

-- Apply label to users
CREATE USER TRUONG_KHOA INDENTIFIED BY 0;
GRANT CONNECT TO TRUONG_KHOA;
GRANT SELECT ON OLS_MANAGER.notification_ols_pol TO TRUONG_KHOA;

CREATE USER TRUONG_DON_VI INDENTIFIED BY 0;
GRANT CONNECT TO TRUONG_DON_VI;
GRANT SELECT ON OLS_MANAGER.notification_ols_pol TO TRUONG_DON_VI;

CREATE USER GIAO_VU INDENTIFIED BY 0;
GRANT CONNECT TO GIAO_VU;
GRANT SELECT ON OLS_MANAGER.notification_ols_pol TO GIAO_VU;

CREATE USER GIANG_VIEN INDENTIFIED BY 0;
GRANT CONNECT TO GIANG_VIEN;
GRANT SELECT ON OLS_MANAGER.notification_ols_pol TO GIANG_VIEN;

CREATE USER SINH_VIEN INDENTIFIED BY 0;
GRANT CONNECT TO SINH_VIEN;
GRANT SELECT ON OLS_MANAGER.notification_ols_pol TO SINH_VIEN;

BEGIN
    sa_user_admin.set_user_label('notification_ols_pol', 'TRUONG_KHOA', 'TK:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1,CS2');
    sa_user_admin.set_user_label('notification_ols_pol', 'TRUONG_DON_VI', 'TDV:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS2');
    sa_user_admin.set_user_label('notification_ols_pol', 'GIAO_VU', 'GVu:HTTT,CNPM,KHMT,CNTT,TGMT,MMT:CS1');
    sa_user_admin.set_user_label('notification_ols_pol', 'GIANG_VIEN', 'GVi:HTTT:CS2');
    sa_user_admin.set_user_label('notification_ols_pol', 'SINH_VIEN', 'SV:CNTT:CS2');
END;
/




