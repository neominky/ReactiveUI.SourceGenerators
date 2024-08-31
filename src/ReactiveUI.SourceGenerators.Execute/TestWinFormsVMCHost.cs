﻿// Copyright (c) 2024 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using ReactiveUI.SourceGenerators.WinForms;

namespace SGReactiveUI.SourceGenerators.Test;

/// <summary>
/// TestWinFormsVMCHost.
/// </summary>
/// <seealso cref="System.Windows.Forms.UserControl" />
/// <seealso cref="ReactiveUI.IReactiveObject" />
/// <seealso cref="ReactiveUI.IViewFor" />
[ViewModelControlHost(nameof(UserControl))]
public partial class TestWinFormsVMCHost;
