/*
Предполагается, что для свзязи таблиц Product, Categories многие ко многим используется доп. связующая таблица CategoriesProducts,
содержащая ProductId и CategoryId
*/

Select Products.Name, Categories.Name
From Products
Left join CategoriesProducts
on Products.ProductId = CategoriesProducts.ProductId
left join Categories
on Categories.CategoryId = CategoriesProducts.CategoryId
