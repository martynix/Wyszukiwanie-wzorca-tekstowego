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


		    int pozycja=test.find(wzorzec);  // size_t u�ywa si� do zapami�tania pozycji, na jakiej PIERWSZY raz wyst�pi� wzorzec w tekscie;

            if (pozycja == string::npos) // npos - no position, czyli wzorzec nie wyst�puje w tek�cie
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

