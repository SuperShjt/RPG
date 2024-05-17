﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class QuestCompletionItem
    {
        public Items Details { get; set; }
        public int Quantity { get; set; }
        public QuestCompletionItem(Items details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
