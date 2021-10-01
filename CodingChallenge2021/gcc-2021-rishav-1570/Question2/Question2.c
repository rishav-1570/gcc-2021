#include <stdio.h>

int securitiesBuying(int z,int security_value[])
{
    int no_of_stocks=0;
   // participants code here


    return no_of_stocks;
}

int main(void) {
    int z;
    scanf("%d",&z);
    int input,security_value[50],size=0;
    while(scanf("%d",&input)==1)
    {
    	security_value[size++]=input;
    }
    
    int no_of_stocks_purchased = securitiesBuying(z,security_value);
    printf("%d",no_of_stocks_purchased);
    return 0;
}
