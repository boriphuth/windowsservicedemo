﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.WindowsService
{
	[RunInstaller(true)]
	public partial class HttpJobRunnerInstaller : System.Configuration.Install.Installer
	{
		public HttpJobRunnerInstaller()
		{
			InitializeComponent();
		}
	}
}
