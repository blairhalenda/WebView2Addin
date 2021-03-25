# WebView2Addin
A sample Excel VSTO add-in for troubleshooting ```TAB``` issue in WebView2.

Must have Excel installed.

## Setup
Clone repository
```
git clone https://github.com/blair-halenda/WebView2Addin.git
```

Open ```WebView2Addin.sln``` in Visual Studio and debug.

## Setting Up Debug Environment
1. Before debugging go to ``Tools > Options > Debugging > General`` and ensure ``Just My Code`` is unchecked.

![Uncheck Just My Code](/images/UncheckJustMyCode.png)

2. Follow **Reproducing Error** steps below to reproduce error
3. The debugger should hit an exception in the WebView2 source code
4. Click ``Decompile Source`` to access the exception

![Decompile Source](/images/DecompileSourceCode.png)

5. View the exception details

![Decompile Source](/images/Error.png)


## Reproducing Error

![Reproducing Error](/images/WebView2.png)

While debugging:
1. Select ```WebView2 Addin``` from the Excel Ribbon
2. Click ```Show Task Pane``` button
3. Click inside the task pane and press ```TAB``` key


## Error
![Error](/images/WebViewError.png)
