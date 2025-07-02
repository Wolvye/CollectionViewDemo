using CollectionViewDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo.Selectors
{
    internal class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var produkt = item as Produkt;
            if (!produkt.HasOffer)
            {
                Application
                    .Current
                    .Resources
                    .TryGetValue("ProductStyle", out var ProductStyle);
                return ProductStyle as DataTemplate;
            }
            else
            {
                    Application
                        .Current
                        .Resources
                        .TryGetValue("OfferStyle", out var OfferStyle);
                    return OfferStyle as DataTemplate;
            }
            return new DataTemplate();

        }

    }
}
