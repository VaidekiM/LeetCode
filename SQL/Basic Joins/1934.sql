/* 1934. Confirmation rate */
SELECT s.user_id, round(if(count(c.user_id) > 0, 
            (sum(c.action = 'confirmed') / count(c.user_id)),
            0),
        2) as confirmation_rate 
FROM Signups s
LEFT JOIN Confirmations c
ON s.user_id = c.user_id
GROUP BY s.user_id;