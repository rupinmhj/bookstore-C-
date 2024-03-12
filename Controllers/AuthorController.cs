using Microsoft.AspNetCore.Mvc;
public class AuthorController:Controller{
    public IActionResult Index(){
        Author a1=new(){Id=1,Name="Rupin",Gender='M',Address="Thecho",Email="rupinmaharjan@gmail.com"};
        Author a2=new(){Id=2,Name="Elina",Gender='F',Address="Salyan",Email="elinakc820@gmail.com"};
        List<Author>authors=[a1,a2];
        return View(authors);
    }
}