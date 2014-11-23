
var OrderUpdater = function ()
{
	var orderID = -1,
	addProductUrl,
	removeProductFromOrderUrl,
	updateOrderItemUrl;

	

	function updateQuantity(productID, orderID, btn)
	{
		event.preventDefault();
		var quantity = $(btn).closest(".row").find("input[type='text']").val();

		updateQuantityInternal(productID, orderID, quantity);
		return false;
	}

	function updateQuantityInternal(productID, orderID, quantity)
	{
		$.ajax({
			type: "POST",
			url: updateOrderItemUrl,
			data: { productID: productID,
				orderID: orderID,
				quantity: quantity
			},
			success: function (data)
			{
				//TODO: show an OK icon?

			}
		});
	}

	function updateOrderIdOnNavLinks(orderID)
	{
		var oldHref, i,
		$cartLinks = $(".cartLink");

		for (i = 0; i < $cartLinks.length; i++)
		{
			oldHref = $($cartLinks[i]).attr("href");
			$($cartLinks[i]).attr("href", oldHref.substring(0, oldHref.indexOf("?")) + "?orderID=" + orderID);
		}
	}

	return {
		addToCart: function (productID)
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
					if (orderID == -1)
					{
						orderID = data.ordID;
						updateOrderIdOnNavLinks(orderID)
					}
				}
			});

		},
		removeFromCart: function (productID, orderID, btn)
		{
			$.ajax({
				type: "POST",
				url: removeProductFromOrderUrl,
				data: { productID: productID,
					orderID: orderID,
					quantity: 0
				},
				success: function (data)
				{
					$(btn).closest(".row").hide();

				},
				error: function (err, data)
				{
					//TODO: error messaging
				}
			});
		},
		updateQuantity: updateQuantity,
		init: function (addUrl, updateUrl, removeUrl)
		{
			addProductUrl = addUrl;
			removeProductFromOrderUrl = removeUrl;
			updateOrderItemUrl = updateUrl;
		}

	};
} ();