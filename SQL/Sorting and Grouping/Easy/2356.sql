/* 2356. Number of unique subjects taught by each teacher */
SELECT teacher_id, COUNT(DISTINCT(subject_id)) as cnt
FROM Teacher
GROUP BY teacher_id;