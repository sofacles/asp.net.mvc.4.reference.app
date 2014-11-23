
var OrderUpdater = function ()
{
	var orderID = -1,
	addProductUrl,
	updateOrderItemUrl;

	function addToCart(productID)
	{
		$.ajax({
			type: "POST",
			url: addProductUrl,
			data: { productID: productID,
				orderID: orderID,
				quantity: 1
			},
			success: function (data)
			{
				var oldHref;
				if (orderID == -1)
				{
					orderID = data.ordID;
					oldHref = $(".cartLink").attr("href");
					$(".cartLink").attr("href", oldHref.substring(0, oldHref.indexOf("?")) + "?orderID=" + orderID);
				}
			}
		});

	}

	function updateQuantity(productID, orderID, btn)
	{
		event.preventDefault();
		var quantity = $(btn).parent().find("input[type='text']").val()
		$.ajax({
			type: "POST",
			url: updateOrderItemUrl,
			data: { productID: productID,
				orderID: orderID,
				quantity: quantity
			},
			success: function (data)
			{
				//maybe show an OK icon?
			}
		});
		return false;
	}

	return {
		addToCart: addToCart,
		updateQuantity: updateQuantity,
		init: function (addUrl, updateUrl)
		{
			addProductUrl = addUrl;
			updateOrderItemUrl = updateUrl;
		}

	};
} ();