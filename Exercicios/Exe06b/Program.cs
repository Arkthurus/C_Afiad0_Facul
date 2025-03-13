//PASSOS PARA RESOLVER O EXERCÍCIO
//1 - Criar um vetor de 1000 posições
//2 - Preencher o vetor com valores aleatórios
//3 - Imprimir o vetor na tela
//4 - Ordenar o vetor com o Bubble Sort

//Criar um vetor de valores inteiros
int[] vetor = new int[10];

//Gerar um valor randômico
Random r = new Random();

//Preencher o vetor com valores aleatórios
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(10);
}

//Imprimir o vetor com valores aletatórios
for (int j = 0; j < vetor.Length; j++)
{
    Console.Write(vetor[j] + " ");
}

//Ordenar o vetor com o Bubble Sort

bool troca = false;


    troca=false;
    for (int j = 1; j < vetor.Length ; j++){
            
        for (int i = 0; i < vetor.Length - j; i++){

            int atual=vetor[i], prox=vetor[i+1];
        //Trocar valores
            if (atual > prox)
            {
                troca=true;
                int aux = vetor[i];
                vetor[i] = vetor[i+1];
                vetor[i+1] = aux;
            }
        }

    }
Console.WriteLine("\n");
//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}