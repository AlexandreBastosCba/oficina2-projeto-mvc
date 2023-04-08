## Criação de uma nova migration
Add-Migration PrimeirasTabelas -Context Contexto -Project Repositorio -StartupProject UI

 

## Execução da migration no banco de dados
Update-Database -Context Contexto -Project Repositorio -StartupProject UI

 

## Remove a última migração (acumula as alterações de código que foram feitas para a migração).
Remove-Migration -Context Contexto -Project Repositorio -StartupProject UI