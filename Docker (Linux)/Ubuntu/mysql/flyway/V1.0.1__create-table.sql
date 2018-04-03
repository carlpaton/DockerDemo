/* intentional de-normalized  */

CREATE TABLE `flyway_demo`.`employee` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `surname` VARCHAR(45) NULL,
  `title` VARCHAR(45) NULL,
  `job_role` VARCHAR(45) NULL,
  `start_date` DATETIME NULL,
  PRIMARY KEY (`id`));
