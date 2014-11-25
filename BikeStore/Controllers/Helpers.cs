﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BikeStore.Controllers
{
	public static class Helpers
	{
		//Lifted from: http://stackoverflow.com/questions/14473597/include-antiforgerytoken-in-ajax-post-asp-net-mvc
		public static MvcHtmlString AntiForgeryTokenForAjaxPost(this HtmlHelper helper)
		{
			var antiForgeryInputTag = helper.AntiForgeryToken().ToString();
			// Above gets the following: <input name="__RequestVerificationToken" type="hidden" value="PnQE7R0MIBBAzC7SqtVvwrJpGbRvPgzWHo5dSyoSaZoabRjf9pCyzjujYBU_qKDJmwIOiPRDwBV1TNVdXFVgzAvN9_l2yt9-nf4Owif0qIDz7WRAmydVPIm6_pmJAI--wvvFQO7g0VvoFArFtAR2v6Ch1wmXCZ89v0-lNOGZLZc1" />
			var removedStart = antiForgeryInputTag.Replace(@"<input name=""__RequestVerificationToken"" type=""hidden"" value=""", "");
			var tokenValue = removedStart.Replace(@""" />", "");
			if (antiForgeryInputTag == removedStart || removedStart == tokenValue)
				throw new InvalidOperationException("Oops! The Html.AntiForgeryToken() method seems to return something I did not expect.");
			return new MvcHtmlString(tokenValue);
		}
	}
}