SELECT   ml.UserName, ml.LastLogin
FROM         mgmt_login_102 ml
inner join mgmt_login_service_102 ms on ms.UserName = ml.UserName and ms.ServiceId = 3
--RIGHT OUTER JOIN mgmt_login_service_102 ON mgmt_login_102.UserName = mgmt_login_service_102.UserName
where ml.UserName not in
(
SELECT   distinct ml.UserName
FROM         mgmt_login_102 ml
inner join mgmt_login_service_102 ms on ms.UserName = ml.UserName and ms.ServiceId = 40
--RIGHT OUTER JOIN mgmt_login_service_102 ON mgmt_login_102.UserName = mgmt_login_service_102.UserName
) and ml.WESmandant LIKE 'tkcpos%'
order by ml.LastLogin desc