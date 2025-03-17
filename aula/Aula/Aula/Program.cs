/*
 Criar instâncias de Aluno
 */

using Aula.Domain;

var aluno1 = new Aluno(1, "Jocy", new Email("jocy@email.com"), new Telefone("11-99999-8888"));
var aluno2 = new Aluno(2, "Gabriela", new Email("gabriela@email.com"), new Telefone("11-99999-8888"));
var aluno3 = new Aluno(3, "Ellie", new Email("ellie@email.com"), new Telefone("11-99999-8888"));

Console.WriteLine("Alunos criados!");


/*
 Criar instâncias de Treinamentos
 */
var treinamento1 = new Treinamento(1, new CodigoTreinamento("PY10"), "Introdução a Python", 40, 2);
var treinamento2 = new Treinamento(2, new CodigoTreinamento("JA10"), "Introdução a Python", 16, 10);

Console.WriteLine("Treinamentos criados!");



/* 
Criar instâncias de service para adicionar um curso e um aluno
*/
var service = new MatriculaService();
service.adicionarAluno(aluno1);
service.adicionarAluno(aluno2);
service.adicionarAluno(aluno3);
Console.WriteLine("Alunos adicionados!");

service.adicionarTreinamento(treinamento1);
service.adicionarTreinamento(treinamento2);
Console.WriteLine("Treinamentos adicionados!");


/* /*  
Criar matrícula de um aluno
*/
var matricula1 = service.matricularAluno(aluno1, treinamento1, Periodo.NOITE, new DateOnly(2024, 3, 10));
var matricula2 = service.matricularAluno(aluno2, treinamento1, Periodo.NOITE, new DateOnly(2024, 3, 11));
Console.WriteLine("Matrículas criadas com sucesso!\n");