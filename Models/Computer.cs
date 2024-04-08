using System;

namespace RazorPages.Models
{
	public class Computer
	{
		public string Processor { get; set; }
    public string Memory { get; set; }
    public string Graphics { get; set; }
    public string Motherboard { get; set; }
    public string Power { get; set; }
    public string Chassis { get; set; }
    public List<string> Storage { get; set; }
	}
}