﻿#pragma checksum "..\..\..\..\UsersControl\PesquisarUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5DC547499304F7257382B4221B03B29C3EC1F5E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using GestaoDeContas.Converters;
using GestaoDeContas.UsersControl;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GestaoDeContas.UsersControl {
    
    
    /// <summary>
    /// PesquisarUserControl
    /// </summary>
    public partial class PesquisarUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\UsersControl\PesquisarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPrecoI;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\UsersControl\PesquisarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPrecoF;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\UsersControl\PesquisarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboSituacao;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\UsersControl\PesquisarUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboNecessidade;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestaoDeContas;component/userscontrol/pesquisarusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UsersControl\PesquisarUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TextBoxPrecoI = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\..\UsersControl\PesquisarUserControl.xaml"
            this.TextBoxPrecoI.LostFocus += new System.Windows.RoutedEventHandler(this.TextBoxPrecoI_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxPrecoF = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\..\UsersControl\PesquisarUserControl.xaml"
            this.TextBoxPrecoF.LostFocus += new System.Windows.RoutedEventHandler(this.TextBoxPrecoF_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboSituacao = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.comboNecessidade = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

