/*
� ������ ������ ��������������, ��� ��� ����� ������ �� ������ ������ Products � Categories
������������ ������������� ������� CategoriesProducts ������ ProductId � CategoriesId
*/

Select Products.Name, Categories.Name
From Products
Left join CategoriesProducts
on Products.ProductId = CategoriesProducts.ProductId
left join Categories
on Categories.CategoryId = CategoriesProducts.CategoryId