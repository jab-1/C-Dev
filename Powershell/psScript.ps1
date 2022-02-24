mkdir myFolder
cd myFolder
ni myFile.txt
echo "Hello World" > myFile.txt
gc myFile.txt
echo "Goodbye World" >> myFile.txt
gc myFile.txt
mkdir secondFolder
mv "myFile.txt" -Destination "secondFolder"
