-- Write your query below
WITH max_score AS (   
    SELECT 
    student_id,
    MAX(score) AS score
    FROM exam_results
    GROUP BY student_id
)
SELECT er.student_id, MIN(er.exam_id) AS exam_id,mr.score AS score
FROM exam_results AS er INNER JOIN max_score AS mr
ON er.student_id = mr.student_id AND er.score = mr.score
GROUP BY
    er.student_id,
    mr.score;