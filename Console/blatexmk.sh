#!/bin/bash

fileName=${1%.*}
logFileName="blatexmk.log"

echo 'Your input file is "'$fileName.btex'"'

if [ ! -e "$fileName.btex" ] ##btexファイルが存在しない
then
	echo -e "\e[31;1merror\e[m: No such file." 
	exit 1
fi

#btex -> tex
echo -e "\e[36;1mbegin to translate to tex file.\e[m"
java -jar $(dirname `realpath $0`)/betterTex.jar $fileName.btex > $(dirname `realpath $0`)/$logFileName

if [ $? = 2 ] #error: failed to compile btex to tex
then
    echo -e "\e[31;1merror\e[m: Failed to compile btex file to tex file.\e[33;1m"
    cat $logFileName
    exit 1
fi

#tex -> pdf
echo -e "\e[36;1mbegin to compile to pdf.\e[m"
cp $(dirname `realpath $0`)/$logFileName $fileName.tex
latexmk $fileName.tex

rm $logFileName
