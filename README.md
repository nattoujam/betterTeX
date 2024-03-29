**author: nattoujam**

**date: 2019/04/13**

# betterTeX
Be easier to handle to writing by TeX


# Requirement
java, texlive, latexmk

# Description
texのソースファイルの記述で、\begin{}...\end{}ではなく、\func()以降にインデントを1つ下げて書くようにする。

(例)
~~~
\begin{abstract}          \func(abstract)
...                 ->      ...
\end{abstract}            
~~~
~~~
\begin{tabular}{l|c|c|c|}\hline           \func(tabular, {l|c|c|c|}\hline)
...                                 ->      ...
\end{tabular}                             
~~~

# Usage

入力ファイルは.btex及び.tex。

以下のコマンドで入力ファイル内の\begin{}...\end{}が\func()...\endに置き換え、標準出力に出力。

> java -jar betterTex.jar [mytext.btex]

以下のコマンドで、btex→tex→pdfと自動でコンパイルし、pdfファイルを出力する。(拡張子は無くてもよい)

> blatexmk [mytext.btex]
  
# Install
作業ファルダ内に全ファイルをコピー、もしくは必要に応じてbetterTex.jarやblatexmk.shのパスを通す。
