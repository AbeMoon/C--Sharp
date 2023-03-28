#include <stdio.h>
#include <string.h>

int main(int argc, char const *argv[]){

    FILE *entrada;
    FILE *salida;

    entrada = fopen("salida.pdf","rb");
    salida = fopen("decryp.pdf","wb");

    char letras;
    do{
        letra = fgetch(entrada);
        letra = letra-1;

        putc(letra,salida);

    } while (letra != EOF);
    fclose(entrada);
    fclose(salida);
}