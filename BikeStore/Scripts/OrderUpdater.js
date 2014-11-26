
var OrderUpdater = function ()
{
	var orderID = -1,
	addProductUrl,
	removeProductFromOrderUrl,
	updateOrderItemUrl;

	function updateQuantityInternal(productID, orderID, quantity)
	{
		$.ajax({
			type: "POST",
			url: updateOrderItemUrl,
			data: { __RequestVerificationToken: window.token,
				productID: productID,
				orderID: orderID,
				quantity: quantity
			},
			success: function (data)
			{
				//TODO: show an OK icon
			}
		});
	}

	function updateOrderIdOnNavLinks(orderID)
	{
		var oldHref, i,
		queryStringParams,
		newQueryString,
		$cartLinks = $(".cartLink");

		for (i = 0; i < $cartLinks.length; i++)
		{
			oldHref = $($cartLinks[i]).attr("href");
			newQueryString = "?";
			queryStringParams = oldHref.substring(oldHref.indexOf("?") + 1).split("&");
			for (var j = 0; j < queryStringParams.length; j++)
			{
				if (queryStringParams[j].indexOf("orderID") == -1)
				{
					newQueryString += queryStringParams[j];
				}
				else
				{
					var qsParts = queryStringParams[j].split("=");
					newQueryString += qsParts[0] + "=" + orderID;
				}
				newQueryString += "&";
			}
			//trim the last '&'
			newQueryString = newQueryString.substring(0, newQueryString.length - 1);
			$($cartLinks[i]).attr("href", oldHref.substring(0, oldHref.indexOf("?")) + newQueryString);
		}
	}

	return {
		addToCart: function (productID)
		{
			$.ajax({
				type: "POST",
				url: addProductUrl,
				data: { __RequestVerificationToken: window.token,
					productID: productID,
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
			event.preventDefault();
			var form = $('#__AjaxAntiForgeryForm');
			var token = $('input[name="__RequestVerificationToken"]', form).val();
			$.ajax({
				type: "POST",
				url: removeProductFromOrderUrl,
				data: { __RequestVerificationToken: token,
					productID: productID,
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

			return false;
		},
		updateQuantity: function(productID, orderID, btn)
		{
			event.preventDefault();
			var quantity = $(btn).closest(".row").find("input[type='text']").val();

			updateQuantityInternal(productID, orderID, quantity);
			return false;
		},
		init: function (addUrl, updateUrl, removeUrl)
		{
			addProductUrl = addUrl;
			removeProductFromOrderUrl = removeUrl;
			updateOrderItemUrl = updateUrl;

		}
	};
} ();