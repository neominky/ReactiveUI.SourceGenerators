﻿//HintName: TestVM.ObservableAsPropertyFromObservable.g.cs
// <auto-generated/>
using ReactiveUI;

#pragma warning disable
#nullable enable

namespace TestNs
{
    /// <summary>
    /// Partial class for the TestVM which contains ReactiveUI Reactive property initialization.
    /// </summary>
    public partial class TestVM
    {
        /// <inheritdoc cref="Test5Property"/>
        private int _test5Property;

        /// <inheritdoc cref="_test5PropertyHelper"/>
        private ReactiveUI.ObservableAsPropertyHelper<int>? _test5PropertyHelper;

        /// <inheritdoc cref="_test5Property"/>
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        [global::System.Text.Json.Serialization.JsonIncludeAttribute()]
        public int Test5Property { get => _test5Property = _test5PropertyHelper?.Value ?? _test5Property; }

        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        protected void InitializeOAPH()
        {
            _test5PropertyHelper = Test5!.ToProperty(this, nameof(Test5Property));
        }
    }
}
#nullable restore
#pragma warning restore