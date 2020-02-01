CREATE TABLE "GAMES" (
    "GameID" integer NOT NULL,
    "Name" text NULL,
    "Desc" text NULL,
    CONSTRAINT "PK_GAMES" PRIMARY KEY ("GameID")
);

CREATE TABLE "Competitions" (
    "CompID" integer NOT NULL,
    "GameID" integer NOT NULL,
    "Location" text NULL,
    "ExtraData" text NULL,
    "Date" timestamp without time zone NOT NULL,
    "RunningFields" integer NULL,
    "ScheduleNumber" integer NULL,
    field1preferred text NULL,
    field2preferred text NULL,
    field3preferred text NULL,
    field4preferred text NULL,
    field5preferred text NULL,
    field6preferred text NULL,
    CONSTRAINT "PK_Competitions" PRIMARY KEY ("CompID"),
    CONSTRAINT "FK_Competitions_GAMES_GameID" FOREIGN KEY ("GameID") REFERENCES "GAMES" ("GameID") ON DELETE CASCADE
);

CREATE TABLE "ScoreMethods" (
    "MethodID" integer NOT NULL,
    "GameID" integer NOT NULL,
    "Name" text NULL,
    CONSTRAINT "PK_ScoreMethods" PRIMARY KEY ("MethodID"),
    CONSTRAINT "FK_ScoreMethods_GAMES_GameID" FOREIGN KEY ("GameID") REFERENCES "GAMES" ("GameID") ON DELETE CASCADE
);

CREATE TABLE "Fields" (
    "FieldID" integer NOT NULL,
    "FieldNumber" integer NOT NULL,
    "CompID" integer NOT NULL,
    "CurrentTeamID" integer NOT NULL,
    "Using" boolean NOT NULL,
    "Junior" boolean NOT NULL,
    "CurrentTeamNumber" text NULL,
    CONSTRAINT "PK_Fields" PRIMARY KEY ("FieldID"),
    CONSTRAINT "FK_Fields_Competitions_CompID" FOREIGN KEY ("CompID") REFERENCES "Competitions" ("CompID") ON DELETE CASCADE
);

CREATE TABLE "StudentTeams" (
    "TeamID" integer NOT NULL,
    "CompID" integer NOT NULL,
    "TeamName" text NOT NULL,
    "TeamNumberBranch" integer NOT NULL,
    "TeamNumberSpecific" integer NOT NULL,
    "Location" text NULL,
    "Coach" text NOT NULL,
    "FieldR1" integer NOT NULL,
    "FieldR2" integer NOT NULL,
    CONSTRAINT "PK_StudentTeams" PRIMARY KEY ("TeamID"),
    CONSTRAINT "FK_StudentTeams_Competitions_CompID" FOREIGN KEY ("CompID") REFERENCES "Competitions" ("CompID") ON DELETE CASCADE
);

CREATE TABLE "ScoreAmounts" (
    "AmountID" integer NOT NULL,
    "MethodID" integer NOT NULL,
    "AmountName" text NULL,
    "Amount" integer NOT NULL,
    CONSTRAINT "PK_ScoreAmounts" PRIMARY KEY ("AmountID"),
    CONSTRAINT "FK_ScoreAmounts_ScoreMethods_MethodID" FOREIGN KEY ("MethodID") REFERENCES "ScoreMethods" ("MethodID") ON DELETE CASCADE
);

CREATE TABLE "RoundEntries" (
    "EntryID" integer NOT NULL,
    "TeamID" integer NOT NULL,
    "Round" integer NOT NULL,
    "Score" integer NOT NULL,
    "Time" integer NOT NULL,
    "Data" text NULL,
    "Rerun" boolean NOT NULL,
    "Usable" boolean NOT NULL,
    "JudgeConfirmNotes" text NULL,
    "StudentInitials" text NULL,
    "TimeStamp" text NULL,
    "Field" integer NOT NULL,
    CONSTRAINT "PK_RoundEntries" PRIMARY KEY ("EntryID"),
    CONSTRAINT "FK_RoundEntries_StudentTeams_TeamID" FOREIGN KEY ("TeamID") REFERENCES "StudentTeams" ("TeamID") ON DELETE CASCADE
);

CREATE INDEX "IX_Competitions_GameID" ON "Competitions" ("GameID");

CREATE INDEX "IX_Fields_CompID" ON "Fields" ("CompID");

CREATE INDEX "IX_RoundEntries_TeamID" ON "RoundEntries" ("TeamID");

CREATE INDEX "IX_ScoreAmounts_MethodID" ON "ScoreAmounts" ("MethodID");

CREATE INDEX "IX_ScoreMethods_GameID" ON "ScoreMethods" ("GameID");

CREATE INDEX "IX_StudentTeams_CompID" ON "StudentTeams" ("CompID");


CREATE TABLE "TeamMatches" (
    "MatchID" integer NOT NULL,
    "TeamID" integer NOT NULL,
    "Order" integer NOT NULL,
    "Rerun" boolean NOT NULL,
    "Test" boolean NOT NULL,
    "Completed" boolean NOT NULL,
    CONSTRAINT "PK_TeamMatches" PRIMARY KEY ("MatchID"),
    CONSTRAINT "FK_TeamMatches_StudentTeams_TeamID" FOREIGN KEY ("TeamID") REFERENCES "StudentTeams" ("TeamID") ON DELETE CASCADE
);

INSERT INTO "StudentTeams" ("TeamID", "Coach", "CompID", "FieldR1", "FieldR2", "Location", "TeamName", "TeamNumberBranch", "TeamNumberSpecific")
VALUES (1, 'Robofest', 1, 0, 0, 'Robofest', 'Team One', 1001, 1);

INSERT INTO "StudentTeams" ("TeamID", "Coach", "CompID", "FieldR1", "FieldR2", "Location", "TeamName", "TeamNumberBranch", "TeamNumberSpecific")
VALUES (2, 'Robofest', 1, 0, 0, 'Robofest', 'Team Two', 1001, 2);

CREATE INDEX "IX_TeamMatches_TeamID" ON "TeamMatches" ("TeamID");


ALTER TABLE "TeamMatches" DROP CONSTRAINT "FK_TeamMatches_StudentTeams_TeamID";

ALTER TABLE "TeamMatches" RENAME COLUMN "TeamID" TO "CompID";

ALTER INDEX "IX_TeamMatches_TeamID" RENAME TO "IX_TeamMatches_CompID";

ALTER TABLE "TeamMatches" ADD "TeamNumber" text NULL;

ALTER TABLE "TeamMatches" ADD CONSTRAINT "FK_TeamMatches_Competitions_CompID" FOREIGN KEY ("CompID") REFERENCES "Competitions" ("CompID") ON DELETE CASCADE;


ALTER TABLE "TeamMatches" ADD "RoundNum" integer NOT NULL DEFAULT 0;


ALTER TABLE "TeamMatches" DROP CONSTRAINT "FK_TeamMatches_Competitions_CompID";

DROP INDEX "IX_TeamMatches_CompID";


ALTER TABLE "Competitions" ALTER COLUMN field6preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field6preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field6preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field5preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field5preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field5preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field4preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field4preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field4preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field3preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field3preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field3preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field2preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field2preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field2preferred DROP DEFAULT;

ALTER TABLE "Competitions" ALTER COLUMN field1preferred TYPE text;
ALTER TABLE "Competitions" ALTER COLUMN field1preferred DROP NOT NULL;
ALTER TABLE "Competitions" ALTER COLUMN field1preferred DROP DEFAULT;


ALTER TABLE "Competitions" ADD validmatch1 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch2 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch3 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch4 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch5 boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "Competitions" ADD validmatch6 boolean NOT NULL DEFAULT FALSE;


