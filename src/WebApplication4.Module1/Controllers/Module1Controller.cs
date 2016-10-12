﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc;
using System.Linq;
using WebApplication4.Infrastructure;

namespace AspNet5ModularApp.ExtensionA.Controllers
{
  public class Module1Controller : Controller
  {
    public ActionResult Index()
    {
      return this.View(ExtensionManager.Extensions.Select(e => e.Name));
    }
  }
}