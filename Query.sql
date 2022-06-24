SELECT Products.Name, Categories.Name
	FROM Products
	LEFT JOIN ProductsCategories ON Products.Id = ProductsCategories.ProductId
	LEFT JOIN Categories ON Categories.Id = ProductsCategories.CategoryId;