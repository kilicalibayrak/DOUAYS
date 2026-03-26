using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DOUAYS.Models;

namespace DOUAYS.Controllers;

public class HomeController : Controller
{
    //Bilgi Takip İstek Mail Tablosu
    public IActionResult BilgiTakip()
    {
        return View();
    }
    
    //Depo Malzemeleri Tahmini Dağılım Tablosu
    public IActionResult DepoMalzemeleri()
    {
        return View();
    }

    //Tanıtım Müdürlüğü Haftalık Program
    public IActionResult HaftalıkProgram()
    {
        return View();
    }
    //Seminer ve Kariyer Takvimi
    public IActionResult SeminerKariyerTakvimi()
    {
        return View();
    }
    //Ziyaret Edilen Kurum Listesi
    public IActionResult ZiyaretKurum()
    {
        return View();
    }
    //Aday Öğrenci Bilgi Formu
    public IActionResult AdayOgrenci()
    {
        return View();
    }
   
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
