﻿using System.Drawing;

using IC.Client.DataLayer;
using IC.Client.FormModel.Base.EventHandlers;
using IC.Client.FormModel.Interfaces.ControlModel.Base;

namespace IC.Client.FormModel.Interfaces.ControlModel
{
    /// <summary>
    /// Presents ProductByShareControl interface
    /// 
    /// 2017/01/30 - Created, VTyagunov
    /// </summary>
    public interface IProductByShareControl : IControl
    {
        /// <summary>Click Control Event</summary>
        event ControlEventHandlers.ClickControlEventHandler ClickControlEvent;
        /// <summary>Click Button Up Event</summary>
        event ControlEventHandlers.ClickButtonUpEventHandler ClickButtonUpEvent;
        /// <summary>Click Button Down Event</summary>
        event ControlEventHandlers.ClickButtonDownEventHandler ClickButtonDownEvent;
        /// <summary>Click Button Back Event</summary>
        event ControlEventHandlers.ClickButtonBackEventHandler ClickButtonBackEvent;
        /// <summary>Click Button Settings Event</summary>
        event ControlEventHandlers.ClickButtonSettingsEventHandler ClickButtonSettingsEvent;

        /// <summary>
        /// Use for does button up action
        /// </summary>  
        void BtnUp();

        /// <summary>
        /// Use for does button down action
        /// </summary> 
        void BtnDown();

        /// <summary>
        /// Use for clear all control data
        /// </summary>
        void ClearControlData();

        /// <summary>
        /// Use for set Article value
        /// </summary>
        /// <param name="vendorCode">Vendor Code string</param>
        void SetVendorCode(string vendorCode);

        /// <summary>
        /// Use for set Product info
        /// </summary>
        /// <param name="productInfo">Product Info string</param>
        void SetProductByShareInfo(string productInfo);

        /// <summary>
        /// Use for set Product name
        /// </summary>
        /// <param name="productName">Product Name string</param>
        void SetProductName(string productName);

        /// <summary>
        /// Use for set barcode value
        /// </summary>
        /// <param name="barCode">Product BarCode string</param>
        void SetBarCode(string barCode);

        /// <summary>
        /// Use for set product price
        /// </summary>
        /// <param name="price">Product Price string</param>
        void SetPrice(string price);

        /// <summary>
        /// Use for set system localization
        /// </summary>
        /// <param name="systemTranslationData">System Translation Data object</param>
        void Localize(SystemTranslationData systemTranslationData);

        /// <summary>
        /// Use for set image to Logo
        /// </summary>
        /// <param name="image">Image object</param>
        void SetLogoImage(Image image);
    }
}