using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class ItemService
    {
        public List<Item> GetAllItems()
        {
            List<Item> items = null;
            using (var context = new DataContext())
            {
               
                items = context.Items.Where(i => i.Price >= 1000)
                    .OrderByDescending(i => i.Price)
                    .ToList();
            }

            return items;
        }

    }


}
