using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages;

public class IndexModel : PageModel
{
    public string Processor = "AMD Ryzen 9 3900X";
    public string Memory = "IRDM 32GB 3600MHz DDR4";
    public string Graphics = "Nvidia RTX 3080";
    public string Motherboard = "Gigabyte X570 Aorus Master";
    public string Power = "Corsair 850W 80+Gold";
    public string Case = "Jonsbo UMX4 Mid Tower";
    public string[] Storage = { "Samsung 970 Evo Plus 1TB", "Seagate FireCuda 520 2TB", "Seagate IronWolf 3TB"};
    public int Count = 0;
    public void OnGet()
    {
        
    }
    public void OnPost()
    {
        Count++;
    }

    private readonly ILogger<IndexModel> _logger;    

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
}
