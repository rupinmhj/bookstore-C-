using Microsoft.AspNetCore.Mvc;
public class PublisherController:Controller{
    public IActionResult Index(){
        Publisher a1=new(){PublisherId=101,Name="AnitaUs",Address="Darchula",EstablishedDate=new DateTime(1995, 1, 1)};
        Publisher a2=new(){PublisherId=102,Name="SudarshanUp",Address="Budhanilkantha",EstablishedDate=new DateTime(1997, 1, 1)};
        List<Publisher>publishers=[a1,a2];
        return View(publishers);
    }
}