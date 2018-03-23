/* intentional de-normalized  */

INSERT INTO `flyway_demo`.`employee`
(`name`,
`surname`,
`title`,
`job_role`,
`start_date`)
VALUES
('Carl',
'Paton',
'Mr',
'Software Developer',
NOW());
SELECT * FROM flyway_demo.employee;