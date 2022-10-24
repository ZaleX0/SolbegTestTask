# Solbeg Test Task
Create an ASP.NET MVC App which reverses the entered string by means of recursion.

## How it works
1. Input string from the form is sent by using the method with `HttpPostAttribute`  in [HomeController](Controllers/HomeController.cs).
2. Then it is processed by the [ReverseStringService](Services/ReverseStringService.cs) where the recursive algorithm is implemented.
3. The reversed string is returned in the `ViewResult` from the controller method to the **value of the text input** in [Index.html](Views/Home/Index.cshtml).
