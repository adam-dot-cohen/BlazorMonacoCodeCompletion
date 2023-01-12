#pragma checksum "E:\github\BlazorMonacoCodeCompletion\BlazorMonaco\BlazorMonaco\MonacoDiffEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecd6416b321002e09db53548e8920e4c2db6835f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMonaco
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 2 "E:\github\BlazorMonacoCodeCompletion\BlazorMonaco\BlazorMonaco\MonacoDiffEditor.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 3 "E:\github\BlazorMonacoCodeCompletion\BlazorMonaco\BlazorMonaco\MonacoDiffEditor.razor"
using System.Text.Json;

#line default
#line hidden
    public partial class MonacoDiffEditor : MonacoEditorBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", 
#line 5 "E:\github\BlazorMonacoCodeCompletion\BlazorMonaco\BlazorMonaco\MonacoDiffEditor.razor"
          Id

#line default
#line hidden
            );
            __builder.AddAttribute(2, "class", "monaco-editor-container" + " " + (
#line 5 "E:\github\BlazorMonacoCodeCompletion\BlazorMonaco\BlazorMonaco\MonacoDiffEditor.razor"
                                              CssClass

#line default
#line hidden
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 7 "E:\github\BlazorMonacoCodeCompletion\BlazorMonaco\BlazorMonaco\MonacoDiffEditor.razor"
       
    [Parameter] public Func<MonacoDiffEditor, StandaloneDiffEditorConstructionOptions> ConstructionOptions { get; set; }
    [Parameter] public EventCallback<MonacoDiffEditor> OnDidUpdateDiff { get; set; }

    // Events for the original editor (left)
    [Parameter] public EventCallback<MonacoEditor> OnDidCompositionEndOriginal { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidCompositionStartOriginal { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnContextMenuOriginal { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidBlurEditorTextOriginal { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidBlurEditorWidgetOriginal { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidChangeConfigurationOriginal { get; set; }
    [Parameter] public EventCallback<CursorPositionChangedEvent> OnDidChangeCursorPositionOriginal { get; set; }
    [Parameter] public EventCallback<CursorSelectionChangedEvent> OnDidChangeCursorSelectionOriginal { get; set; }
    [Parameter] public EventCallback<ModelChangedEvent> OnDidChangeModelOriginal { get; set; }
    [Parameter] public EventCallback<ModelContentChangedEvent> OnDidChangeModelContentOriginal { get; set; }
    [Parameter] public EventCallback<ModelDecorationsChangedEvent> OnDidChangeModelDecorationsOriginal { get; set; }
    [Parameter] public EventCallback<ModelLanguageChangedEvent> OnDidChangeModelLanguageOriginal { get; set; }
    [Parameter] public EventCallback<ModelLanguageConfigurationChangedEvent> OnDidChangeModelLanguageConfigurationOriginal { get; set; }
    [Parameter] public EventCallback<ModelOptionsChangedEvent> OnDidChangeModelOptionsOriginal { get; set; }
    [Parameter] public EventCallback<ContentSizeChangedEvent> OnDidContentSizeChangeOriginal { get; set; }
    [Parameter] public EventCallback<MonacoEditorBase> OnDidDisposeOriginal { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidFocusEditorTextOriginal { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidFocusEditorWidgetOriginal { get; set; }
    [Parameter] public EventCallback<MonacoEditorBase> OnDidInitOriginal { get; set; }
    [Parameter] public EventCallback<EditorLayoutInfo> OnDidLayoutChangeOriginal { get; set; }
    [Parameter] public EventCallback<PasteEvent> OnDidPasteOriginal { get; set; }
    [Parameter] public EventCallback<ScrollEvent> OnDidScrollChangeOriginal { get; set; }
    [Parameter] public EventCallback<KeyboardEvent> OnKeyDownOriginal { get; set; }
    [Parameter] public EventCallback<KeyboardEvent> OnKeyUpOriginal { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnMouseDownOriginal { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnMouseLeaveOriginal { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnMouseMoveOriginal { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnMouseUpOriginal { get; set; }

    // Events for the modified editor (right)
    [Parameter] public EventCallback<MonacoEditor> OnDidCompositionEndModified { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidCompositionStartModified { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnContextMenuModified { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidBlurEditorTextModified { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidBlurEditorWidgetModified { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidChangeConfigurationModified { get; set; }
    [Parameter] public EventCallback<CursorPositionChangedEvent> OnDidChangeCursorPositionModified { get; set; }
    [Parameter] public EventCallback<CursorSelectionChangedEvent> OnDidChangeCursorSelectionModified { get; set; }
    [Parameter] public EventCallback<ModelChangedEvent> OnDidChangeModelModified { get; set; }
    [Parameter] public EventCallback<ModelContentChangedEvent> OnDidChangeModelContentModified { get; set; }
    [Parameter] public EventCallback<ModelDecorationsChangedEvent> OnDidChangeModelDecorationsModified { get; set; }
    [Parameter] public EventCallback<ModelLanguageChangedEvent> OnDidChangeModelLanguageModified { get; set; }
    [Parameter] public EventCallback<ModelLanguageConfigurationChangedEvent> OnDidChangeModelLanguageConfigurationModified { get; set; }
    [Parameter] public EventCallback<ModelOptionsChangedEvent> OnDidChangeModelOptionsModified { get; set; }
    [Parameter] public EventCallback<ContentSizeChangedEvent> OnDidContentSizeChangeModified { get; set; }
    [Parameter] public EventCallback<MonacoEditorBase> OnDidDisposeModified { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidFocusEditorTextModified { get; set; }
    [Parameter] public EventCallback<MonacoEditor> OnDidFocusEditorWidgetModified { get; set; }
    [Parameter] public EventCallback<MonacoEditorBase> OnDidInitModified { get; set; }
    [Parameter] public EventCallback<EditorLayoutInfo> OnDidLayoutChangeModified { get; set; }
    [Parameter] public EventCallback<PasteEvent> OnDidPasteModified { get; set; }
    [Parameter] public EventCallback<ScrollEvent> OnDidScrollChangeModified { get; set; }
    [Parameter] public EventCallback<KeyboardEvent> OnKeyDownModified { get; set; }
    [Parameter] public EventCallback<KeyboardEvent> OnKeyUpModified { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnMouseDownModified { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnMouseLeaveModified { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnMouseMoveModified { get; set; }
    [Parameter] public EventCallback<EditorMouseEvent> OnMouseUpModified { get; set; }

    public MonacoEditor OriginalEditor { get; set; }
    public MonacoEditor ModifiedEditor { get; set; }

    public override void Dispose()
    {
        OriginalEditor?.Dispose();
        ModifiedEditor?.Dispose();
        base.Dispose();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            // Get options
            var options = ConstructionOptions?.Invoke(this);

            // Prepare the line numbers callback
            LineNumbersLambda = options.LineNumbersLambda;
            if (LineNumbersLambda != null)
            {
                options.LineNumbers = "function";
                options.LineNumbersLambda = null;
            }

            // Create the editor
            await MonacoDiffEditor.CreateDiffEditor(Id, options, jsObjectRef);

            // Create the bridges for the inner editors
#pragma warning disable BL0005
            OriginalEditor = MonacoEditor.CreateVirtualEditor(Id + "_original");
            OriginalEditor.OnDidCompositionEnd = OnDidCompositionEndOriginal;
            OriginalEditor.OnDidCompositionStart = OnDidCompositionStartOriginal;
            OriginalEditor.OnContextMenu = OnContextMenuOriginal;
            OriginalEditor.OnDidBlurEditorText = OnDidBlurEditorTextOriginal;
            OriginalEditor.OnDidBlurEditorWidget = OnDidBlurEditorWidgetOriginal;
            OriginalEditor.OnDidChangeConfiguration = OnDidChangeConfigurationOriginal;
            OriginalEditor.OnDidChangeCursorPosition = OnDidChangeCursorPositionOriginal;
            OriginalEditor.OnDidChangeCursorSelection = OnDidChangeCursorSelectionOriginal;
            OriginalEditor.OnDidChangeModel = OnDidChangeModelOriginal;
            OriginalEditor.OnDidChangeModelContent = OnDidChangeModelContentOriginal;
            OriginalEditor.OnDidChangeModelDecorations = OnDidChangeModelDecorationsOriginal;
            OriginalEditor.OnDidChangeModelLanguage = OnDidChangeModelLanguageOriginal;
            OriginalEditor.OnDidChangeModelLanguageConfiguration = OnDidChangeModelLanguageConfigurationOriginal;
            OriginalEditor.OnDidChangeModelOptions = OnDidChangeModelOptionsOriginal;
            OriginalEditor.OnDidContentSizeChange = OnDidContentSizeChangeOriginal;
            OriginalEditor.OnDidDispose = OnDidDisposeOriginal;
            OriginalEditor.OnDidFocusEditorText = OnDidFocusEditorTextOriginal;
            OriginalEditor.OnDidFocusEditorWidget = OnDidFocusEditorWidgetOriginal;
            OriginalEditor.OnDidInit = OnDidInitOriginal;
            OriginalEditor.OnDidLayoutChange = OnDidLayoutChangeOriginal;
            OriginalEditor.OnDidPaste = OnDidPasteOriginal;
            OriginalEditor.OnDidScrollChange = OnDidScrollChangeOriginal;
            OriginalEditor.OnKeyDown = OnKeyDownOriginal;
            OriginalEditor.OnKeyUp = OnKeyUpOriginal;
            OriginalEditor.OnMouseDown = OnMouseDownOriginal;
            OriginalEditor.OnMouseLeave = OnMouseLeaveOriginal;
            OriginalEditor.OnMouseMove = OnMouseMoveOriginal;
            OriginalEditor.OnMouseUp = OnMouseUpOriginal;
            await OriginalEditor.SetEventListeners();
            await OriginalEditor.OnDidInit.InvokeAsync(OriginalEditor);

            ModifiedEditor = MonacoEditor.CreateVirtualEditor(Id + "_modified");
            ModifiedEditor.OnDidCompositionEnd = OnDidCompositionEndModified;
            ModifiedEditor.OnDidCompositionStart = OnDidCompositionStartModified;
            ModifiedEditor.OnContextMenu = OnContextMenuModified;
            ModifiedEditor.OnDidBlurEditorText = OnDidBlurEditorTextModified;
            ModifiedEditor.OnDidBlurEditorWidget = OnDidBlurEditorWidgetModified;
            ModifiedEditor.OnDidChangeConfiguration = OnDidChangeConfigurationModified;
            ModifiedEditor.OnDidChangeCursorPosition = OnDidChangeCursorPositionModified;
            ModifiedEditor.OnDidChangeCursorSelection = OnDidChangeCursorSelectionModified;
            ModifiedEditor.OnDidChangeModel = OnDidChangeModelModified;
            ModifiedEditor.OnDidChangeModelContent = OnDidChangeModelContentModified;
            ModifiedEditor.OnDidChangeModelDecorations = OnDidChangeModelDecorationsModified;
            ModifiedEditor.OnDidChangeModelLanguage = OnDidChangeModelLanguageModified;
            ModifiedEditor.OnDidChangeModelLanguageConfiguration = OnDidChangeModelLanguageConfigurationModified;
            ModifiedEditor.OnDidChangeModelOptions = OnDidChangeModelOptionsModified;
            ModifiedEditor.OnDidContentSizeChange = OnDidContentSizeChangeModified;
            ModifiedEditor.OnDidDispose = OnDidDisposeModified;
            ModifiedEditor.OnDidFocusEditorText = OnDidFocusEditorTextModified;
            ModifiedEditor.OnDidFocusEditorWidget = OnDidFocusEditorWidgetModified;
            ModifiedEditor.OnDidInit = OnDidInitModified;
            ModifiedEditor.OnDidLayoutChange = OnDidLayoutChangeModified;
            ModifiedEditor.OnDidPaste = OnDidPasteModified;
            ModifiedEditor.OnDidScrollChange = OnDidScrollChangeModified;
            ModifiedEditor.OnKeyDown = OnKeyDownModified;
            ModifiedEditor.OnKeyUp = OnKeyUpModified;
            ModifiedEditor.OnMouseDown = OnMouseDownModified;
            ModifiedEditor.OnMouseLeave = OnMouseLeaveModified;
            ModifiedEditor.OnMouseMove = OnMouseMoveModified;
            ModifiedEditor.OnMouseUp = OnMouseUpModified;
            await ModifiedEditor.SetEventListeners();
            await ModifiedEditor.OnDidInit.InvokeAsync(ModifiedEditor);
#pragma warning restore BL0005
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    internal override async Task SetEventListeners()
    {
        if (OnDidUpdateDiff.HasDelegate)
            await SetEventListener("OnDidUpdateDiff");
        await base.SetEventListeners();
    }

    [JSInvokable]
    public override async Task EventCallback(string eventName, string eventJson)
    {
        var jsonOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        switch (eventName)
        {
            case "OnDidUpdateDiff": await OnDidUpdateDiff.InvokeAsync(this); break;
        }
        await base.EventCallback(eventName, eventJson);
    }

    #region Instance Methods

    // getDiffLineInformationForModified

    // getDiffLineInformationForOriginal

    // getLineChanges

    public async Task<DiffEditorModel> GetModel()
    {
        if (jsRuntime == null)
            return default;
        return await jsRuntime.InvokeAsync<DiffEditorModel>("blazorMonaco.editor.getInstanceDiffModel", Id);
    }

    // restoreViewState

    // saveViewState

    public async Task SetModel(DiffEditorModel model)
    {
        if (jsRuntime == null)
            return;
        await jsRuntime.InvokeVoidAsync("blazorMonaco.editor.setInstanceDiffModel", Id, model);
    }

    // updateOptions

    #endregion

#line default
#line hidden
    }
}
#pragma warning restore 1591
