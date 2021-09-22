using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace DropDown
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            RibbonDropDownItem item;
            using (var reader = new StreamReader(@"...\test.csv"))
            {
                while (!reader.EndOfStream)
                {
                    item = Factory.CreateRibbonDropDownItem();
                    var line = reader.ReadLine();
                    item.Label = line;
                    dropDown1.Items.Add(item);
                }
            }
        }
    }
}
