﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("KCStoreModel", "FK_OrderItem_Order", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DAL.Order), "OrderItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DAL.OrderItem), true)]
[assembly: EdmRelationshipAttribute("KCStoreModel", "FK_OrderItem_Product", "Product", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DAL.Product), "OrderItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DAL.OrderItem), true)]

#endregion

namespace DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class KCStoreEntities11_15 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new KCStoreEntities11_15 object using the connection string found in the 'KCStoreEntities11_15' section of the application configuration file.
        /// </summary>
        public KCStoreEntities11_15() : base("name=KCStoreEntities11_15", "KCStoreEntities11_15")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new KCStoreEntities11_15 object.
        /// </summary>
        public KCStoreEntities11_15(string connectionString) : base(connectionString, "KCStoreEntities11_15")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new KCStoreEntities11_15 object.
        /// </summary>
        public KCStoreEntities11_15(EntityConnection connection) : base(connection, "KCStoreEntities11_15")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrderItem> OrderItems
        {
            get
            {
                if ((_OrderItems == null))
                {
                    _OrderItems = base.CreateObjectSet<OrderItem>("OrderItems");
                }
                return _OrderItems;
            }
        }
        private ObjectSet<OrderItem> _OrderItems;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OrderItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrderItems(OrderItem orderItem)
        {
            base.AddObject("OrderItems", orderItem);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }

        #endregion

        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectResult<Product> Product_Select()
        {
            return base.ExecuteFunction<Product>("Product_Select");
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        public ObjectResult<Product> Product_Select(MergeOption mergeOption)
        {
            return base.ExecuteFunction<Product>("Product_Select", mergeOption);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="ipAddress">No Metadata Documentation available.</param>
        public ObjectResult<Nullable<global::System.Guid>> Order_Create(global::System.String ipAddress)
        {
            ObjectParameter ipAddressParameter;
            if (ipAddress != null)
            {
                ipAddressParameter = new ObjectParameter("ipAddress", ipAddress);
            }
            else
            {
                ipAddressParameter = new ObjectParameter("ipAddress", typeof(global::System.String));
            }
    
            return base.ExecuteFunction<Nullable<global::System.Guid>>("Order_Create", ipAddressParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="ipAddress">No Metadata Documentation available.</param>
        /// <param name="customerName">No Metadata Documentation available.</param>
        /// <param name="emailAddress">No Metadata Documentation available.</param>
        /// <param name="shippingAddress">No Metadata Documentation available.</param>
        /// <param name="phoneNumber">No Metadata Documentation available.</param>
        public ObjectResult<Nullable<global::System.Guid>> Order_Update(global::System.String ipAddress, global::System.String customerName, global::System.String emailAddress, global::System.String shippingAddress, global::System.String phoneNumber)
        {
            ObjectParameter ipAddressParameter;
            if (ipAddress != null)
            {
                ipAddressParameter = new ObjectParameter("ipAddress", ipAddress);
            }
            else
            {
                ipAddressParameter = new ObjectParameter("ipAddress", typeof(global::System.String));
            }
    
            ObjectParameter customerNameParameter;
            if (customerName != null)
            {
                customerNameParameter = new ObjectParameter("customerName", customerName);
            }
            else
            {
                customerNameParameter = new ObjectParameter("customerName", typeof(global::System.String));
            }
    
            ObjectParameter emailAddressParameter;
            if (emailAddress != null)
            {
                emailAddressParameter = new ObjectParameter("emailAddress", emailAddress);
            }
            else
            {
                emailAddressParameter = new ObjectParameter("emailAddress", typeof(global::System.String));
            }
    
            ObjectParameter shippingAddressParameter;
            if (shippingAddress != null)
            {
                shippingAddressParameter = new ObjectParameter("shippingAddress", shippingAddress);
            }
            else
            {
                shippingAddressParameter = new ObjectParameter("shippingAddress", typeof(global::System.String));
            }
    
            ObjectParameter phoneNumberParameter;
            if (phoneNumber != null)
            {
                phoneNumberParameter = new ObjectParameter("phoneNumber", phoneNumber);
            }
            else
            {
                phoneNumberParameter = new ObjectParameter("phoneNumber", typeof(global::System.String));
            }
    
            return base.ExecuteFunction<Nullable<global::System.Guid>>("Order_Update", ipAddressParameter, customerNameParameter, emailAddressParameter, shippingAddressParameter, phoneNumberParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="ipAddress">No Metadata Documentation available.</param>
        /// <param name="productID">No Metadata Documentation available.</param>
        /// <param name="quantity">No Metadata Documentation available.</param>
        /// <param name="orderID">No Metadata Documentation available.</param>
        public ObjectResult<Nullable<global::System.Guid>> OrderItem_AddOrUpdate(global::System.String ipAddress, Nullable<global::System.Guid> productID, Nullable<global::System.Int32> quantity, Nullable<global::System.Guid> orderID)
        {
            ObjectParameter ipAddressParameter;
            if (ipAddress != null)
            {
                ipAddressParameter = new ObjectParameter("ipAddress", ipAddress);
            }
            else
            {
                ipAddressParameter = new ObjectParameter("ipAddress", typeof(global::System.String));
            }
    
            ObjectParameter productIDParameter;
            if (productID.HasValue)
            {
                productIDParameter = new ObjectParameter("productID", productID);
            }
            else
            {
                productIDParameter = new ObjectParameter("productID", typeof(global::System.Guid));
            }
    
            ObjectParameter quantityParameter;
            if (quantity.HasValue)
            {
                quantityParameter = new ObjectParameter("quantity", quantity);
            }
            else
            {
                quantityParameter = new ObjectParameter("quantity", typeof(global::System.Int32));
            }
    
            ObjectParameter orderIDParameter;
            if (orderID.HasValue)
            {
                orderIDParameter = new ObjectParameter("orderID", orderID);
            }
            else
            {
                orderIDParameter = new ObjectParameter("orderID", typeof(global::System.Guid));
            }
    
            return base.ExecuteFunction<Nullable<global::System.Guid>>("OrderItem_AddOrUpdate", ipAddressParameter, productIDParameter, quantityParameter, orderIDParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="productID">No Metadata Documentation available.</param>
        /// <param name="orderID">No Metadata Documentation available.</param>
        public ObjectResult<Nullable<global::System.Guid>> OrderItem_Remove(Nullable<global::System.Guid> productID, Nullable<global::System.Guid> orderID)
        {
            ObjectParameter productIDParameter;
            if (productID.HasValue)
            {
                productIDParameter = new ObjectParameter("productID", productID);
            }
            else
            {
                productIDParameter = new ObjectParameter("productID", typeof(global::System.Guid));
            }
    
            ObjectParameter orderIDParameter;
            if (orderID.HasValue)
            {
                orderIDParameter = new ObjectParameter("orderID", orderID);
            }
            else
            {
                orderIDParameter = new ObjectParameter("orderID", typeof(global::System.Guid));
            }
    
            return base.ExecuteFunction<Nullable<global::System.Guid>>("OrderItem_Remove", productIDParameter, orderIDParameter);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="iD">No Metadata Documentation available.</param>
        public int Order_Delete(Nullable<global::System.Guid> iD)
        {
            ObjectParameter iDParameter;
            if (iD.HasValue)
            {
                iDParameter = new ObjectParameter("ID", iD);
            }
            else
            {
                iDParameter = new ObjectParameter("ID", typeof(global::System.Guid));
            }
    
            return base.ExecuteFunction("Order_Delete", iDParameter);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="KCStoreModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="userIP">Initial value of the UserIP property.</param>
        /// <param name="orderedOn">Initial value of the OrderedOn property.</param>
        /// <param name="customerName">Initial value of the CustomerName property.</param>
        /// <param name="emailAddress">Initial value of the EmailAddress property.</param>
        /// <param name="shippingAddress">Initial value of the ShippingAddress property.</param>
        /// <param name="phoneNumber">Initial value of the PhoneNumber property.</param>
        /// <param name="id">Initial value of the ID property.</param>
        public static Order CreateOrder(global::System.String userIP, global::System.DateTime orderedOn, global::System.String customerName, global::System.String emailAddress, global::System.String shippingAddress, global::System.String phoneNumber, global::System.Guid id)
        {
            Order order = new Order();
            order.UserIP = userIP;
            order.OrderedOn = orderedOn;
            order.CustomerName = customerName;
            order.EmailAddress = emailAddress;
            order.ShippingAddress = shippingAddress;
            order.PhoneNumber = phoneNumber;
            order.ID = id;
            return order;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserIP
        {
            get
            {
                return _UserIP;
            }
            set
            {
                OnUserIPChanging(value);
                ReportPropertyChanging("UserIP");
                _UserIP = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserIP");
                OnUserIPChanged();
            }
        }
        private global::System.String _UserIP;
        partial void OnUserIPChanging(global::System.String value);
        partial void OnUserIPChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime OrderedOn
        {
            get
            {
                return _OrderedOn;
            }
            set
            {
                OnOrderedOnChanging(value);
                ReportPropertyChanging("OrderedOn");
                _OrderedOn = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderedOn");
                OnOrderedOnChanged();
            }
        }
        private global::System.DateTime _OrderedOn;
        partial void OnOrderedOnChanging(global::System.DateTime value);
        partial void OnOrderedOnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                OnCustomerNameChanging(value);
                ReportPropertyChanging("CustomerName");
                _CustomerName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CustomerName");
                OnCustomerNameChanged();
            }
        }
        private global::System.String _CustomerName;
        partial void OnCustomerNameChanging(global::System.String value);
        partial void OnCustomerNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ShippingAddress
        {
            get
            {
                return _ShippingAddress;
            }
            set
            {
                OnShippingAddressChanging(value);
                ReportPropertyChanging("ShippingAddress");
                _ShippingAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ShippingAddress");
                OnShippingAddressChanged();
            }
        }
        private global::System.String _ShippingAddress;
        partial void OnShippingAddressChanging(global::System.String value);
        partial void OnShippingAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                OnPhoneNumberChanging(value);
                ReportPropertyChanging("PhoneNumber");
                _PhoneNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PhoneNumber");
                OnPhoneNumberChanged();
            }
        }
        private global::System.String _PhoneNumber;
        partial void OnPhoneNumberChanging(global::System.String value);
        partial void OnPhoneNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Guid _ID;
        partial void OnIDChanging(global::System.Guid value);
        partial void OnIDChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("KCStoreModel", "FK_OrderItem_Order", "OrderItem")]
        public EntityCollection<OrderItem> OrderItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderItem>("KCStoreModel.FK_OrderItem_Order", "OrderItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderItem>("KCStoreModel.FK_OrderItem_Order", "OrderItem", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="KCStoreModel", Name="OrderItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrderItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OrderItem object.
        /// </summary>
        /// <param name="productID">Initial value of the productID property.</param>
        /// <param name="quantity">Initial value of the quantity property.</param>
        /// <param name="orderID">Initial value of the orderID property.</param>
        /// <param name="id">Initial value of the id property.</param>
        public static OrderItem CreateOrderItem(global::System.Guid productID, global::System.Int32 quantity, global::System.Guid orderID, global::System.Guid id)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.productID = productID;
            orderItem.quantity = quantity;
            orderItem.orderID = orderID;
            orderItem.id = id;
            return orderItem;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid productID
        {
            get
            {
                return _productID;
            }
            set
            {
                OnproductIDChanging(value);
                ReportPropertyChanging("productID");
                _productID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("productID");
                OnproductIDChanged();
            }
        }
        private global::System.Guid _productID;
        partial void OnproductIDChanging(global::System.Guid value);
        partial void OnproductIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                OnquantityChanging(value);
                ReportPropertyChanging("quantity");
                _quantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("quantity");
                OnquantityChanged();
            }
        }
        private global::System.Int32 _quantity;
        partial void OnquantityChanging(global::System.Int32 value);
        partial void OnquantityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid orderID
        {
            get
            {
                return _orderID;
            }
            set
            {
                OnorderIDChanging(value);
                ReportPropertyChanging("orderID");
                _orderID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("orderID");
                OnorderIDChanged();
            }
        }
        private global::System.Guid _orderID;
        partial void OnorderIDChanging(global::System.Guid value);
        partial void OnorderIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Guid _id;
        partial void OnidChanging(global::System.Guid value);
        partial void OnidChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("KCStoreModel", "FK_OrderItem_Order", "Order")]
        public Order Order
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("KCStoreModel.FK_OrderItem_Order", "Order").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("KCStoreModel.FK_OrderItem_Order", "Order").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Order> OrderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("KCStoreModel.FK_OrderItem_Order", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Order>("KCStoreModel.FK_OrderItem_Order", "Order", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("KCStoreModel", "FK_OrderItem_Product", "Product")]
        public Product Product
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("KCStoreModel.FK_OrderItem_Product", "Product").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("KCStoreModel.FK_OrderItem_Product", "Product").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Product> ProductReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("KCStoreModel.FK_OrderItem_Product", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Product>("KCStoreModel.FK_OrderItem_Product", "Product", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="KCStoreModel", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="price">Initial value of the price property.</param>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="description">Initial value of the description property.</param>
        public static Product CreateProduct(global::System.String name, global::System.Decimal price, global::System.Guid id, global::System.String description)
        {
            Product product = new Product();
            product.name = name;
            product.price = price;
            product.id = id;
            product.description = description;
            return product;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal price
        {
            get
            {
                return _price;
            }
            set
            {
                OnpriceChanging(value);
                ReportPropertyChanging("price");
                _price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("price");
                OnpriceChanged();
            }
        }
        private global::System.Decimal _price;
        partial void OnpriceChanging(global::System.Decimal value);
        partial void OnpriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Guid _id;
        partial void OnidChanging(global::System.Guid value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String description
        {
            get
            {
                return _description;
            }
            set
            {
                OndescriptionChanging(value);
                ReportPropertyChanging("description");
                _description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("description");
                OndescriptionChanged();
            }
        }
        private global::System.String _description;
        partial void OndescriptionChanging(global::System.String value);
        partial void OndescriptionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("KCStoreModel", "FK_OrderItem_Product", "OrderItem")]
        public EntityCollection<OrderItem> OrderItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderItem>("KCStoreModel.FK_OrderItem_Product", "OrderItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderItem>("KCStoreModel.FK_OrderItem_Product", "OrderItem", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}