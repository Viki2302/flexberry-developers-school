﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Shop
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Запись в накладной.
    /// </summary>
    // *** Start programmer edit section *** (InvoiceItem CustomAttributes)

    // *** End programmer edit section *** (InvoiceItem CustomAttributes)
    [AutoAltered()]
    [Caption("Запись в накладной")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("InvoiceItemE", new string[] {
            "Product as \'Товар\'",
            "Product.Name as \'\'",
            "Product.ProductCode as \'\'",
            "Amount as \'Количество\'",
            "Weight as \'Вес (кг)\'",
            "Price as \'Цена\'",
            "TotalSum as \'Сумма по позиции\'"}, Hidden=new string[] {
            "Product.Name",
            "Product.ProductCode"})]
    [MasterViewDefineAttribute("InvoiceItemE", "Product", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    public class InvoiceItem : ICSSoft.STORMNET.DataObject
    {
        
        private int fAmount;
        
        private double fWeight;
        
        private double fPrice;
        
        private double fTotalSum;
        
        private IIS.Shop.Product fProduct;
        
        private IIS.Shop.Invoice fInvoice;
        
        // *** Start programmer edit section *** (InvoiceItem CustomMembers)

        // *** End programmer edit section *** (InvoiceItem CustomMembers)

        
        /// <summary>
        /// Amount.
        /// </summary>
        // *** Start programmer edit section *** (InvoiceItem.Amount CustomAttributes)

        // *** End programmer edit section *** (InvoiceItem.Amount CustomAttributes)
        public virtual int Amount
        {
            get
            {
                // *** Start programmer edit section *** (InvoiceItem.Amount Get start)

                // *** End programmer edit section *** (InvoiceItem.Amount Get start)
                int result = this.fAmount;
                // *** Start programmer edit section *** (InvoiceItem.Amount Get end)

                // *** End programmer edit section *** (InvoiceItem.Amount Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InvoiceItem.Amount Set start)

                // *** End programmer edit section *** (InvoiceItem.Amount Set start)
                this.fAmount = value;
                // *** Start programmer edit section *** (InvoiceItem.Amount Set end)

                // *** End programmer edit section *** (InvoiceItem.Amount Set end)
            }
        }
        
        /// <summary>
        /// Weight.
        /// </summary>
        // *** Start programmer edit section *** (InvoiceItem.Weight CustomAttributes)

        // *** End programmer edit section *** (InvoiceItem.Weight CustomAttributes)
        public virtual double Weight
        {
            get
            {
                // *** Start programmer edit section *** (InvoiceItem.Weight Get start)

                // *** End programmer edit section *** (InvoiceItem.Weight Get start)
                double result = this.fWeight;
                // *** Start programmer edit section *** (InvoiceItem.Weight Get end)

                // *** End programmer edit section *** (InvoiceItem.Weight Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InvoiceItem.Weight Set start)

                // *** End programmer edit section *** (InvoiceItem.Weight Set start)
                this.fWeight = value;
                // *** Start programmer edit section *** (InvoiceItem.Weight Set end)

                // *** End programmer edit section *** (InvoiceItem.Weight Set end)
            }
        }
        
        /// <summary>
        /// Price.
        /// </summary>
        // *** Start programmer edit section *** (InvoiceItem.Price CustomAttributes)

        // *** End programmer edit section *** (InvoiceItem.Price CustomAttributes)
        public virtual double Price
        {
            get
            {
                // *** Start programmer edit section *** (InvoiceItem.Price Get start)

                // *** End programmer edit section *** (InvoiceItem.Price Get start)
                double result = this.fPrice;
                // *** Start programmer edit section *** (InvoiceItem.Price Get end)

                // *** End programmer edit section *** (InvoiceItem.Price Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InvoiceItem.Price Set start)

                // *** End programmer edit section *** (InvoiceItem.Price Set start)
                this.fPrice = value;
                // *** Start programmer edit section *** (InvoiceItem.Price Set end)

                // *** End programmer edit section *** (InvoiceItem.Price Set end)
            }
        }
        
        /// <summary>
        /// TotalSum.
        /// </summary>
        // *** Start programmer edit section *** (InvoiceItem.TotalSum CustomAttributes)

        // *** End programmer edit section *** (InvoiceItem.TotalSum CustomAttributes)
        public virtual double TotalSum
        {
            get
            {
                // *** Start programmer edit section *** (InvoiceItem.TotalSum Get start)

                // *** End programmer edit section *** (InvoiceItem.TotalSum Get start)
                double result = this.fTotalSum;
                // *** Start programmer edit section *** (InvoiceItem.TotalSum Get end)

                // *** End programmer edit section *** (InvoiceItem.TotalSum Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InvoiceItem.TotalSum Set start)

                // *** End programmer edit section *** (InvoiceItem.TotalSum Set start)
                this.fTotalSum = value;
                // *** Start programmer edit section *** (InvoiceItem.TotalSum Set end)

                // *** End programmer edit section *** (InvoiceItem.TotalSum Set end)
            }
        }
        
        /// <summary>
        /// Запись в накладной.
        /// </summary>
        // *** Start programmer edit section *** (InvoiceItem.Product CustomAttributes)

        // *** End programmer edit section *** (InvoiceItem.Product CustomAttributes)
        [PropertyStorage(new string[] {
                "Товар"})]
        public virtual IIS.Shop.Product Product
        {
            get
            {
                // *** Start programmer edit section *** (InvoiceItem.Product Get start)

                // *** End programmer edit section *** (InvoiceItem.Product Get start)
                IIS.Shop.Product result = this.fProduct;
                // *** Start programmer edit section *** (InvoiceItem.Product Get end)

                // *** End programmer edit section *** (InvoiceItem.Product Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InvoiceItem.Product Set start)

                // *** End programmer edit section *** (InvoiceItem.Product Set start)
                this.fProduct = value;
                // *** Start programmer edit section *** (InvoiceItem.Product Set end)

                // *** End programmer edit section *** (InvoiceItem.Product Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Shop.Invoice.
        /// </summary>
        // *** Start programmer edit section *** (InvoiceItem.Invoice CustomAttributes)

        // *** End programmer edit section *** (InvoiceItem.Invoice CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Накладная"})]
        public virtual IIS.Shop.Invoice Invoice
        {
            get
            {
                // *** Start programmer edit section *** (InvoiceItem.Invoice Get start)

                // *** End programmer edit section *** (InvoiceItem.Invoice Get start)
                IIS.Shop.Invoice result = this.fInvoice;
                // *** Start programmer edit section *** (InvoiceItem.Invoice Get end)

                // *** End programmer edit section *** (InvoiceItem.Invoice Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (InvoiceItem.Invoice Set start)

                // *** End programmer edit section *** (InvoiceItem.Invoice Set start)
                this.fInvoice = value;
                // *** Start programmer edit section *** (InvoiceItem.Invoice Set end)

                // *** End programmer edit section *** (InvoiceItem.Invoice Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "InvoiceItemE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View InvoiceItemE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("InvoiceItemE", typeof(IIS.Shop.InvoiceItem));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of InvoiceItem.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfInvoiceItem CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfInvoiceItem CustomAttributes)
    public class DetailArrayOfInvoiceItem : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Shop.DetailArrayOfInvoiceItem members)

        // *** End programmer edit section *** (IIS.Shop.DetailArrayOfInvoiceItem members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type InvoiceItem by index.
        /// </summary>
        /// <summary>
        /// Adds object with type InvoiceItem.
        /// </summary>
        public DetailArrayOfInvoiceItem(IIS.Shop.Invoice fInvoice) : 
                base(typeof(InvoiceItem), ((ICSSoft.STORMNET.DataObject)(fInvoice)))
        {
        }
        
        public IIS.Shop.InvoiceItem this[int index]
        {
            get
            {
                return ((IIS.Shop.InvoiceItem)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Shop.InvoiceItem dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
