#include <iostream>
#include <stdlib.h>
#include <string>
using namespace std;

int main()
{

string wzorzec, test;

cout<<"Podaj wzorzec: ";
cin>>wzorzec;


 cout<<endl;

 cout<<"Podaj test: ";
 cin>>test;

 while (wzorzec.size()>test.size())
 {
     cout<<"Test powinien byc dluzszy niz wzorzec! ";
     cout<<endl;
     cout<<endl;

     cout<<"Podaj test: ";
     cin>>test;
 }

 cout<<endl;

 //cout<<test<<endl;


		    int pozycja=test.find(wzorzec);  // size_t u¿ywa siê do zapamiêtania pozycji, na jakiej PIERWSZY raz wyst¹pi³ wzorzec w tekscie;

            if (pozycja == string::npos) // npos - no position, czyli wzorzec nie wystêpuje w tekœcie
        {
            cout<<"Nie znaleziono wzorca w tekscie"<<endl;
        }
        else
        {

        do
        {
            cout<<"Wzorzec wystepuje na pozycji: "<<pozycja<<endl;
            pozycja=test.find(wzorzec,pozycja +1 );
        }
        while (pozycja != string::npos);
        }
    return 0;
}

