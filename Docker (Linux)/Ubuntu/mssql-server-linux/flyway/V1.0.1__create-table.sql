/* intentional de-normalized  */

CREATE TABLE employee (
  id int IDENTITY(1,1) PRIMARY KEY,
  name VARCHAR(45) NULL,
  surname VARCHAR(45) NULL,
  title VARCHAR(45) NULL,
  job_role VARCHAR(45) NULL,
  start_date DATETIME NULL);