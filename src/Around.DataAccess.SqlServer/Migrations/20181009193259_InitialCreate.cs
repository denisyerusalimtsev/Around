﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Around.DataAccess.SqlServer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cheques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RentId = table.Column<int>(nullable: false),
                    DateOfCreation = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cheques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Copters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BrandId = table.Column<int>(nullable: false),
                    DroneType = table.Column<int>(nullable: false),
                    CharacteristicId = table.Column<int>(nullable: false),
                    FlightId = table.Column<int>(nullable: false),
                    EquipmentId = table.Column<int>(nullable: false),
                    CameraId = table.Column<int>(nullable: false),
                    RemoteControlId = table.Column<int>(nullable: false),
                    AircraftId = table.Column<int>(nullable: false),
                    ModesId = table.Column<int>(nullable: false),
                    LoadCapacityId = table.Column<int>(nullable: false),
                    TransportCharacteristicsId = table.Column<int>(nullable: false),
                    BatteryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Copters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecordNumber = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastNane = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    TechnicalCenter = table.Column<string>(nullable: true),
                    Snapshot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aircraft",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FlameMaterial = table.Column<int>(nullable: false),
                    HasFoldableDesign = table.Column<bool>(nullable: false),
                    EngineType = table.Column<int>(nullable: false),
                    Connectors = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aircraft_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Battery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ChargingSpeed = table.Column<double>(nullable: false),
                    Capacity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Battery_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Camera",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CameraMount = table.Column<int>(nullable: false),
                    Lens = table.Column<string>(nullable: true),
                    HasCameraRotation = table.Column<bool>(nullable: false),
                    IsoSensetivity = table.Column<string>(nullable: true),
                    Resolution = table.Column<int>(nullable: false),
                    PhotoModes = table.Column<string>(nullable: true),
                    Stabilization = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camera", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Camera_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AmbientTemperature = table.Column<double>(nullable: false),
                    Widht = table.Column<double>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Colour = table.Column<string>(nullable: true),
                    PropellersCount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characteristics_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    HasGps = table.Column<bool>(nullable: false),
                    InternalMemory = table.Column<int>(nullable: false),
                    HasMemoryCardSupport = table.Column<bool>(nullable: false),
                    HasGyroscope = table.Column<bool>(nullable: false),
                    HasMagnetometer = table.Column<bool>(nullable: false),
                    HasAccelerometer = table.Column<bool>(nullable: false),
                    HasBarometer = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    LiftingSpeed = table.Column<double>(nullable: false),
                    DescentSpeed = table.Column<double>(nullable: false),
                    MaximumSpeed = table.Column<double>(nullable: false),
                    MinimumSpeed = table.Column<double>(nullable: false),
                    FlightTime = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flight_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoadCapacity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    LoadMountsCount = table.Column<int>(nullable: false),
                    MaximumWeight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadCapacity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoadCapacity_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    HasTracking = table.Column<bool>(nullable: false),
                    HasTrick = table.Column<bool>(nullable: false),
                    HasReturnBase = table.Column<bool>(nullable: false),
                    HasCfmPositioning = table.Column<bool>(nullable: false),
                    HasFirstPersonView = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modes_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RemoteControl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ControlType = table.Column<int>(nullable: false),
                    HasBuiltInDisplay = table.Column<bool>(nullable: false),
                    HasMobileDeviceMount = table.Column<bool>(nullable: false),
                    Connectors = table.Column<string>(nullable: true),
                    MaximumRadius = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemoteControl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemoteControl_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    HasAutopilot = table.Column<bool>(nullable: false),
                    SeatCount = table.Column<int>(nullable: false),
                    HasAirbag = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportCharacteristics_Copters_Id",
                        column: x => x.Id,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PassportId = table.Column<int>(nullable: false),
                    CreditCardNumber = table.Column<string>(nullable: true),
                    DiscountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Passports_PassportId",
                        column: x => x.PassportId,
                        principalTable: "Passports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    CountryName = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Countries_Brands_Id",
                        column: x => x.Id,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    ValidThru = table.Column<string>(nullable: true),
                    Cvv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Number);
                    table.ForeignKey(
                        name: "FK_CreditCards_Clients_Id",
                        column: x => x.Id,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Percentage = table.Column<double>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    CopterId = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    FinishTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rents_Copters_CopterId",
                        column: x => x.CopterId,
                        principalTable: "Copters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rents_Cheques_Id",
                        column: x => x.Id,
                        principalTable: "Cheques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_PassportId",
                table: "Clients",
                column: "PassportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Id",
                table: "Countries",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_Id",
                table: "CreditCards",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ClientId",
                table: "Discounts",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rents_ClientId",
                table: "Rents",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_CopterId",
                table: "Rents",
                column: "CopterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Aircraft");

            migrationBuilder.DropTable(
                name: "Battery");

            migrationBuilder.DropTable(
                name: "Camera");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "LoadCapacity");

            migrationBuilder.DropTable(
                name: "Modes");

            migrationBuilder.DropTable(
                name: "RemoteControl");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "TransportCharacteristics");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Cheques");

            migrationBuilder.DropTable(
                name: "Copters");

            migrationBuilder.DropTable(
                name: "Passports");
        }
    }
}
