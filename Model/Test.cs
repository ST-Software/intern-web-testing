using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace web_testing.Model
{
    
    class Test : ISelenium
    {
        public void AddLocationStrategy(string strategyName, string functionDefinition)
        {
            throw new NotImplementedException();
        }

        public void AddScript(string scriptContent, string scriptTagId)
        {
            throw new NotImplementedException();
        }

        public void AddSelection(string locator, string optionLocator)
        {
            throw new NotImplementedException();
        }

        public void AllowNativeXpath(string allow)
        {
            throw new NotImplementedException();
        }

        public void AltKeyDown()
        {
            throw new NotImplementedException();
        }

        public void AltKeyUp()
        {
            throw new NotImplementedException();
        }

        public void AnswerOnNextPrompt(string answer)
        {
            throw new NotImplementedException();
        }

        public void AssignId(string locator, string identifier)
        {
            throw new NotImplementedException();
        }

        public void AttachFile(string fieldLocator, string fileLocator)
        {
            throw new NotImplementedException();
        }

        public void CaptureEntirePageScreenshot(string filename, string kwargs)
        {
            throw new NotImplementedException();
        }

        public string CaptureEntirePageScreenshotToString(string kwargs)
        {
            throw new NotImplementedException();
        }

        public void CaptureScreenshot(string filename)
        {
            throw new NotImplementedException();
        }

        public string CaptureScreenshotToString()
        {
            throw new NotImplementedException();
        }

        public void Check(string locator)
        {
            throw new NotImplementedException();
        }

        public void ChooseCancelOnNextConfirmation()
        {
            throw new NotImplementedException();
        }

        public void ChooseOkOnNextConfirmation()
        {
            throw new NotImplementedException();
        }

        public void Click(string locator)
        {
            throw new NotImplementedException();
        }

        public void ClickAt(string locator, string coordString)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ContextMenu(string locator)
        {
            throw new NotImplementedException();
        }

        public void ContextMenuAt(string locator, string coordString)
        {
            throw new NotImplementedException();
        }

        public void ControlKeyDown()
        {
            throw new NotImplementedException();
        }

        public void ControlKeyUp()
        {
            throw new NotImplementedException();
        }

        public void CreateCookie(string nameValuePair, string optionsString)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllVisibleCookies()
        {
            throw new NotImplementedException();
        }

        public void DeleteCookie(string name, string optionsString)
        {
            throw new NotImplementedException();
        }

        public void DeselectPopUp()
        {
            throw new NotImplementedException();
        }

        public void DoubleClick(string locator)
        {
            throw new NotImplementedException();
        }

        public void DoubleClickAt(string locator, string coordString)
        {
            throw new NotImplementedException();
        }

        public void DragAndDrop(string locator, string movementsString)
        {
            throw new NotImplementedException();
        }

        public void DragAndDropToObject(string locatorOfObjectToBeDragged, string locatorOfDragDestinationObject)
        {
            throw new NotImplementedException();
        }

        public void Dragdrop(string locator, string movementsString)
        {
            throw new NotImplementedException();
        }

        public void FireEvent(string locator, string eventName)
        {
            throw new NotImplementedException();
        }

        public void Focus(string locator)
        {
            throw new NotImplementedException();
        }

        public string GetAlert()
        {
            throw new NotImplementedException();
        }

        public string[] GetAllButtons()
        {
            throw new NotImplementedException();
        }

        public string[] GetAllFields()
        {
            throw new NotImplementedException();
        }

        public string[] GetAllLinks()
        {
            throw new NotImplementedException();
        }

        public string[] GetAllWindowIds()
        {
            throw new NotImplementedException();
        }

        public string[] GetAllWindowNames()
        {
            throw new NotImplementedException();
        }

        public string[] GetAllWindowTitles()
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeLocator)
        {
            throw new NotImplementedException();
        }

        public string[] GetAttributeFromAllWindows(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetBodyText()
        {
            throw new NotImplementedException();
        }

        public string GetConfirmation()
        {
            throw new NotImplementedException();
        }

        public string GetCookie()
        {
            throw new NotImplementedException();
        }

        public string GetCookieByName(string name)
        {
            throw new NotImplementedException();
        }

        public decimal GetCSSCount(string cssLocator)
        {
            throw new NotImplementedException();
        }

        public decimal GetCursorPosition(string locator)
        {
            throw new NotImplementedException();
        }

        public decimal GetElementHeight(string locator)
        {
            throw new NotImplementedException();
        }

        public decimal GetElementIndex(string locator)
        {
            throw new NotImplementedException();
        }

        public decimal GetElementPositionLeft(string locator)
        {
            throw new NotImplementedException();
        }

        public decimal GetElementPositionTop(string locator)
        {
            throw new NotImplementedException();
        }

        public decimal GetElementWidth(string locator)
        {
            throw new NotImplementedException();
        }

        public string GetEval(string script)
        {
            throw new NotImplementedException();
        }

        public string GetExpression(string expression)
        {
            throw new NotImplementedException();
        }

        public string GetHtmlSource()
        {
            throw new NotImplementedException();
        }

        public string GetLocation()
        {
            throw new NotImplementedException();
        }

        public decimal GetMouseSpeed()
        {
            throw new NotImplementedException();
        }

        public string GetPrompt()
        {
            throw new NotImplementedException();
        }

        public string GetSelectedId(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string[] GetSelectedIds(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string GetSelectedIndex(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string[] GetSelectedIndexes(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string GetSelectedLabel(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string[] GetSelectedLabels(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string GetSelectedValue(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string[] GetSelectedValues(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string[] GetSelectOptions(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public string GetSpeed()
        {
            throw new NotImplementedException();
        }

        public string GetTable(string tableCellAddress)
        {
            throw new NotImplementedException();
        }

        public string GetText(string locator)
        {
            throw new NotImplementedException();
        }

        public string GetTitle()
        {
            throw new NotImplementedException();
        }

        public string GetValue(string locator)
        {
            throw new NotImplementedException();
        }

        public bool GetWhetherThisFrameMatchFrameExpression(string currentFrameString, string target)
        {
            throw new NotImplementedException();
        }

        public bool GetWhetherThisWindowMatchWindowExpression(string currentWindowString, string target)
        {
            throw new NotImplementedException();
        }

        public decimal GetXpathCount(string xpath)
        {
            throw new NotImplementedException();
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void Highlight(string locator)
        {
            throw new NotImplementedException();
        }

        public void IgnoreAttributesWithoutValue(string ignore)
        {
            throw new NotImplementedException();
        }

        public bool IsAlertPresent()
        {
            throw new NotImplementedException();
        }

        public bool IsChecked(string locator)
        {
            throw new NotImplementedException();
        }

        public bool IsConfirmationPresent()
        {
            throw new NotImplementedException();
        }

        public bool IsCookiePresent(string name)
        {
            throw new NotImplementedException();
        }

        public bool IsEditable(string locator)
        {
            throw new NotImplementedException();
        }

        public bool IsElementPresent(string locator)
        {
            throw new NotImplementedException();
        }

        public bool IsOrdered(string locator1, string locator2)
        {
            throw new NotImplementedException();
        }

        public bool IsPromptPresent()
        {
            throw new NotImplementedException();
        }

        public bool IsSomethingSelected(string selectLocator)
        {
            throw new NotImplementedException();
        }

        public bool IsTextPresent(string pattern)
        {
            throw new NotImplementedException();
        }

        public bool IsVisible(string locator)
        {
            throw new NotImplementedException();
        }

        public void KeyDown(string locator, string keySequence)
        {
            throw new NotImplementedException();
        }

        public void KeyDownNative(string keycode)
        {
            throw new NotImplementedException();
        }

        public void KeyPress(string locator, string keySequence)
        {
            throw new NotImplementedException();
        }

        public void KeyPressNative(string keycode)
        {
            throw new NotImplementedException();
        }

        public void KeyUp(string locator, string keySequence)
        {
            throw new NotImplementedException();
        }

        public void KeyUpNative(string keycode)
        {
            throw new NotImplementedException();
        }

        public void MetaKeyDown()
        {
            throw new NotImplementedException();
        }

        public void MetaKeyUp()
        {
            throw new NotImplementedException();
        }

        public void MouseDown(string locator)
        {
            throw new NotImplementedException();
        }

        public void MouseDownAt(string locator, string coordString)
        {
            throw new NotImplementedException();
        }

        public void MouseDownRight(string locator)
        {
            throw new NotImplementedException();
        }

        public void MouseDownRightAt(string locator, string coordString)
        {
            throw new NotImplementedException();
        }

        public void MouseMove(string locator)
        {
            throw new NotImplementedException();
        }

        public void MouseMoveAt(string locator, string coordString)
        {
            throw new NotImplementedException();
        }

        public void MouseOut(string locator)
        {
            throw new NotImplementedException();
        }

        public void MouseOver(string locator)
        {
            throw new NotImplementedException();
        }

        public void MouseUp(string locator)
        {
            throw new NotImplementedException();
        }

        public void MouseUpAt(string locator, string coordString)
        {
            throw new NotImplementedException();
        }

        public void MouseUpRight(string locator)
        {
            throw new NotImplementedException();
        }

        public void MouseUpRightAt(string locator, string coordString)
        {
            throw new NotImplementedException();
        }

        public void Open(string url)
        {
            throw new NotImplementedException();
        }

        public void OpenWindow(string url, string windowID)
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void RemoveAllSelections(string locator)
        {
            throw new NotImplementedException();
        }

        public void RemoveScript(string scriptTagId)
        {
            throw new NotImplementedException();
        }

        public void RemoveSelection(string locator, string optionLocator)
        {
            throw new NotImplementedException();
        }

        public string RetrieveLastRemoteControlLogs()
        {
            throw new NotImplementedException();
        }

        public void Rollup(string rollupName, string kwargs)
        {
            throw new NotImplementedException();
        }

        public void RunScript(string script)
        {
            throw new NotImplementedException();
        }

        public void Select(string selectLocator, string optionLocator)
        {
            throw new NotImplementedException();
        }

        public void SelectFrame(string locator)
        {
            throw new NotImplementedException();
        }

        public void SelectPopUp(string windowID)
        {
            throw new NotImplementedException();
        }

        public void SelectWindow(string windowID)
        {
            throw new NotImplementedException();
        }

        public void SetBrowserLogLevel(string logLevel)
        {
            throw new NotImplementedException();
        }

        public void SetContext(string context)
        {
            throw new NotImplementedException();
        }

        public void SetCursorPosition(string locator, string position)
        {
            throw new NotImplementedException();
        }

        public void SetExtensionJs(string extensionJs)
        {
            throw new NotImplementedException();
        }

        public void SetMouseSpeed(string pixels)
        {
            throw new NotImplementedException();
        }

        public void SetSpeed(string value)
        {
            throw new NotImplementedException();
        }

        public void SetTimeout(string timeout)
        {
            throw new NotImplementedException();
        }

        public void ShiftKeyDown()
        {
            throw new NotImplementedException();
        }

        public void ShiftKeyUp()
        {
            throw new NotImplementedException();
        }

        public void ShutDownSeleniumServer()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Submit(string formLocator)
        {
            throw new NotImplementedException();
        }

        public void Type(string locator, string value)
        {
            throw new NotImplementedException();
        }

        public void TypeKeys(string locator, string value)
        {
            throw new NotImplementedException();
        }

        public void Uncheck(string locator)
        {
            throw new NotImplementedException();
        }

        public void UseXpathLibrary(string libraryName)
        {
            throw new NotImplementedException();
        }

        public void WaitForCondition(string script, string timeout)
        {
            throw new NotImplementedException();
        }

        public void WaitForFrameToLoad(string frameAddress, string timeout)
        {
            throw new NotImplementedException();
        }

        public void WaitForPageToLoad(string timeout)
        {
            throw new NotImplementedException();
        }

        public void WaitForPopUp(string windowID, string timeout)
        {
            throw new NotImplementedException();
        }

        public void WindowFocus()
        {
            throw new NotImplementedException();
        }

        public void WindowMaximize()
        {
            throw new NotImplementedException();
        }
    }
}
