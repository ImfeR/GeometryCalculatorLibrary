/*
В данном случае предполагается, что при связи многие ко многим таблиц Products и Categories
используется дполнительная табилца CategoriesProducts полями ProductId и CategoriesId
*/

Select Products.Name, Categories.Name
From Products
Left join CategoriesProducts
on Products.ProductId = CategoriesProducts.ProductId
left join Categories
on Categories.CategoryId = CategoriesProducts.CategoryId