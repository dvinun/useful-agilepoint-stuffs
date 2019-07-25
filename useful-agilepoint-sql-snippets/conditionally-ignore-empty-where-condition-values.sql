-- When you have several controls on eForms like dropdowns, textboxes and they may or may not have the value, 
-- or they have 'Please Select...' which is -1, then you need to conditionally run query to exclude/include in the where clause. 
-- This example might come handy.

DECLARE @inputCompany as tinyint 
DECLARE @inputCostCenter as smallint 
DECLARE @inputAssetType as smallint 
DECLARE @inputDesc as varchar(60)
   
set @inputCompany =   '${BatchRequestTable/SearchGLCompany:[this]}'
set @inputCostCenter =  '${BatchRequestTable/SearchGLProftiCenter:[this]}'  
set @inputAssetType =  '${BatchRequestTable/SearchGLAccountType:[this]}' 
set @inputDesc =  '${BatchRequestTable/SearchGLDescription:[this]}'

set @inputCompany = REPLACE(@inputCompany, '-1', ''); 
set @inputCostCenter = REPLACE(@inputCostCenter, '-1', ''); 
set @inputAssetType = REPLACE(@inputAssetType, '-1', ''); 
set @inputDesc = REPLACE(@inputDesc, '-1', ''); 

SELECT  [PRODUCT_CATALOG].[dbo].[vwGLAccounts].GLAccount as GLAccount,  
		[PRODUCT_CATALOG].[dbo].[vwGLAccounts].Description as GLDescription,  
		[PRODUCT_CATALOG].[dbo].[vwGLAccounts].assettype as GLAccountType,   
		[PRODUCT_CATALOG].[dbo].[vwGLCCodes].GLCCode as NewGLCCode, [PRODUCT_CATALOG].[dbo].[vwGLCCodes].Cost as GLCost       
FROM [PRODUCT_CATALOG].[dbo].[vwGLAccounts]       
INNER JOIN [PRODUCT_CATALOG].[dbo].[vwGLCCodes]      
ON [PRODUCT_CATALOG].[dbo].[vwGLAccounts].GLAccount=[PRODUCT_CATALOG].[dbo].[vwGLCCodes].GLAccount    
where    ((@inputCompany = '' and [PRODUCT_CATALOG].[dbo].[vwGLAccounts].company like '%') or [PRODUCT_CATALOG].[dbo].[vwGLAccounts].company = @inputCompany  )   
 and ((@inputCostCenter = '' and [PRODUCT_CATALOG].[dbo].[vwGLAccounts].costcenter like '%') or [PRODUCT_CATALOG].[dbo].[vwGLAccounts].costcenter = @inputCostCenter  )   
 and ((@inputAssetType = '' and [PRODUCT_CATALOG].[dbo].[vwGLAccounts].assettype like '%') or [PRODUCT_CATALOG].[dbo].[vwGLAccounts].assettype = @inputAssetType  )   
 and ((@inputDesc = '' and [PRODUCT_CATALOG].[dbo].[vwGLAccounts].description like '%') or [PRODUCT_CATALOG].[dbo].[vwGLAccounts].description like '%'+@inputDesc+'%'   )   
 ORDER BY [PRODUCT_CATALOG].[dbo].[vwGLAccounts].company, 
 [PRODUCT_CATALOG].[dbo].[vwGLAccounts].costcenter, [PRODUCT_CATALOG].[dbo].[vwGLAccounts].GLAccount
