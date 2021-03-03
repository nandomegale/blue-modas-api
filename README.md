# blue-modas-api

API desenvolvida em .NET CORE 3.1 utilizando C#.

## Executando aplicação

1 - Clone o repositório.

2 - Rode o comando `dotnet run`.

3 - Acesse a URL `http://localhost:5001/products`.


## Endpoints

 GET 
 /products
 /orders
 
POST
  /orders
  
## Exemplo de retorno

GET https://localhost:5001/products
  
  ```json
[{"id":1,"name":"Mochila azul","price":59.99,"img":"https://localhost:5001/images/backpack1.jpg"},{"id":2,"name":"Jaqueta marrom","price":110.99,"img":"https://localhost:5001/images/jacket1.jpg"},{"id":3,"name":"Jaqueta azul","price":99.99,"img":"https://localhost:5001/images/jacket2.jpg"},{"id":4,"name":"Blusa masculina","price":49.99,"img":"https://localhost:5001/images/shirt1.jpg"},{"id":5,"name":"Blusa masculina azul","price":59.99,"img":"https://localhost:5001/images/shirt2.jpg"}]
```
  

