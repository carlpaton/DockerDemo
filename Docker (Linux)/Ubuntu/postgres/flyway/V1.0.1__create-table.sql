/* intentional de-normalized  */

CREATE TABLE public.employee (
  id serial NOT NULL,
  name text,
  surname text,
  title text,
  job_role text,
  start_date date,
  CONSTRAINT employee_pkey PRIMARY KEY (id));
