/**CAST PRA CONVERTIR A INT UN FLOAT*/
SELECT CAST(ROUND(SalesYTD/CommissionPct,0) AS INT) AS Calculo
FROM Sales.SalesPerson
WHERE CommissionPct !=0 --> not 0;