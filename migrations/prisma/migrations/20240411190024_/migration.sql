BEGIN TRY

BEGIN TRAN;

-- CreateTable
CREATE TABLE [dbo].[Aluno] (
    [id] INT NOT NULL IDENTITY(1,1),
    [nome] VARCHAR(255) NOT NULL,
    [usuario] VARCHAR(45) NOT NULL,
    [senha] VARCHAR(60) NOT NULL,
    CONSTRAINT [Aluno_pkey] PRIMARY KEY CLUSTERED ([id])
);

-- CreateTable
CREATE TABLE [dbo].[AlunoTurma] (
    [alunoId] INT NOT NULL,
    [turmaId] INT NOT NULL,
    CONSTRAINT [AlunoTurma_pkey] PRIMARY KEY CLUSTERED ([alunoId],[turmaId])
);

-- CreateTable
CREATE TABLE [dbo].[Turma] (
    [id] INT NOT NULL IDENTITY(1,1),
    [nome] VARCHAR(45) NOT NULL,
    [curso] VARCHAR(60) NOT NULL,
    [ano] INT NOT NULL,
    CONSTRAINT [Turma_pkey] PRIMARY KEY CLUSTERED ([id])
);

-- AddForeignKey
ALTER TABLE [dbo].[AlunoTurma] ADD CONSTRAINT [AlunoTurma_alunoId_fkey] FOREIGN KEY ([alunoId]) REFERENCES [dbo].[Aluno]([id]) ON DELETE NO ACTION ON UPDATE CASCADE;

-- AddForeignKey
ALTER TABLE [dbo].[AlunoTurma] ADD CONSTRAINT [AlunoTurma_turmaId_fkey] FOREIGN KEY ([turmaId]) REFERENCES [dbo].[Turma]([id]) ON DELETE NO ACTION ON UPDATE CASCADE;

COMMIT TRAN;

END TRY
BEGIN CATCH

IF @@TRANCOUNT > 0
BEGIN
    ROLLBACK TRAN;
END;
THROW

END CATCH
