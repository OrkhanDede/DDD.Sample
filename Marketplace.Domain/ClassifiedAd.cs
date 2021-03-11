using System;
using System.Collections.Generic;
using System.Text;
using Marketplace.Domain.ValueObjects;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public ClassifiedAdId Id { get; }
        public ClassifiedAd(ClassifiedAdId id,UserId ownerId)
        {
            Id = id;
            _ownerId = ownerId;
        }

        public void CreateClassifiedAd(ClassifiedAdId id, UserId ownerId)
        {
            var classifiedAd = new ClassifiedAd(id, ownerId);
        }
        private UserId _ownerId;
        private string _title;
        private string _text;
        private decimal _price;

        public void SetTitle(string title) => _title = title;
        public void UpdateText(string text) => _text = text;
        public void UpdatePrice(decimal price) => _price = price;
    }
}
