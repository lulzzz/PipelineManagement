﻿using System;

namespace LagoVista.IoT.Pipeline.Admin.Models
{
    public class CustomPipelineModuleConfiguration : PipelineModuleConfiguration
    {
        public String Script { get; set; }

        public override string ModuleType => PipelineModuleType_Custom;
    }
}
