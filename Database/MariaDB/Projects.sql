-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.2.36-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------



CREATE TABLE IF NOT EXISTS `projects` (
	`ID_Project` int(11) NOT NULL,
	`CE_ID_Key` int(11) DEFAULT NULL,
	`CE_ID_Status` int(11) DEFAULT NULL,
	`CE_ID_ProjectManager` int(11) DEFAULT NULL,
	`CE_ID_Priority` int(11) DEFAULT NULL,
	`CE_ID_Category` int(11) DEFAULT NULL,
	`CE_ID_Customer` int(11) DEFAULT NULL,
	`CE_ID_Urgency` int(11) DEFAULT NULL,
	`Title` text COLLATE latin1_general_ci DEFAULT NULL,
	`Description` text COLLATE latin1_general_ci DEFAULT NULL,
	`BeginDate` datetime DEFAULT NULL,
	`Deadline` datetime DEFAULT NULL,
	`EstimatedResources` int(11) DEFAULT NULL,
	`ImplementationRate` decimal(6,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;







INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (1, 10, 2, 3, 13, 1, 2, N'Tarif 2019', N'Adaptation des tarifs', NULL, CAST(N'2018-12-31' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (2, 10, 1, 2, 12, 1, 2, N'Concept Téléphonie Mobile', N'Définir le concept de téléphonie mobile (qui a droit / quel modèle)

Le concept de téléphonie mobile est intégré au projet MDM Airwatch (#56)', NULL, CAST(N'2019-03-31' AS Date), 3, NULL, NULL, NULL, NULL, 100, 3, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (3, 1, 1, 3, 2, 0, 2, N'Update iTop', N'Upgrade et mise en place du helpdesk (incident & change management)
Update du ITSM Management
Corriger les erreurs lors de l''importation des users depuis Active Directory', NULL, CAST(N'2019-05-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (4, 10, 6, 3, 4, 1, 2, N'Notebook ESB', N'Remplacer et réinstaller les notebooks de direction.
Modificer la connexion VPN à l''infrastructure.

Les notebooks ne seront pas uniquement pour la direction mais également pour les autres collaborateurs ESB

15 notebook supplémentaires ont été commmandés mi-décembre et seront installés dès que possible.', CAST(N'2019-12-01' AS Date), CAST(N'2020-03-31' AS Date), 30, 30, 0, 0, 0, 67, 20, 0, N'Wie am IT Board vom 27.01.2020 besprochen, kann das Projekt 4 durch Projekt 102 "Notebook/iPad ESB - Aufstockung" abgelöst und somit geschlossen werden.
')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (6, 10, 2, 3, 13, 0, 2, N'Concept autorisation pour le département F&S', N'Définir et mettre en place un nouveau concept pour les autorisations SAP pour les collaborateurs du département finances & services.
', NULL, CAST(N'2018-07-11' AS Date), 10, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (7, 1, 0, 3, 5, NULL, 2, N'Logiciel de supervision', N'Mise en place d''un logiciel de supervision pour la gestion des accès et enregistrement des sessions.
Exemple d''outil : Bomgar, Wallix, Remote Desktop Manager
', NULL, CAST(N'2019-12-31' AS Date), 15, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (8, 1, 0, 4, 7, NULL, 2, N'Inventaire matériel ICT', N'Inventorier le matériel ICT et déposer sur chaque périophérique son nom avec QR-Code.
Il faut également le lier à un outil d''inventaire (iTop ? Autre ?)
', NULL, CAST(N'2019-12-31' AS Date), 20, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (9, 10, 2, 3, 13, 1, 2, N'Mise à jour de IDEX-CH2', N'Mise à jour de IDEX-CH2 pour les nouvelles conditions 2019

Partie 1 : messages traditionnels (consommations, clôtures mensuelles) à terminer jusqu''au 19.04.2019.

Partie 2 : automatisation des changements de fournisseurs moins urgent.

La partie 1 est terminée, la partie 2 fera l''objet d''un autre projet', NULL, CAST(N'2019-04-19' AS Date), 15, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (10, 1, 0, 3, 5, NULL, 2, N'Exchange DAG', N'Mise en haute disponibilité d''exchange 2016
', NULL, CAST(N'2019-12-31' AS Date), 10, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (11, 2, 0, 3, 13, 0, 2, N'IDEX Metering', N'Validation des données IDEX pour le metering
', NULL, CAST(N'2018-12-01' AS Date), 0, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (12, 10, 1, 3, 1, 0, 2, N'Documentation Grudis', N'Faire une documentation pour la création de comptes Grudis (canton de Berne, Grundstückdaten-Informationssystem, système d''information sur les données relatives aux immeubles)

Cette tâche sera redonnées à Christian Brawand, une séance est organisée le 25.02.2019 pour finaliser le transfert', NULL, CAST(N'2019-03-31' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (13, 10, 0, 3, 4, 0, 2, N'PC Serge Rau', N'PC physique à changer ou migration sur un environnement virtuel

Ce projet est intégré dans le projet #39 - VDI Windows 10 avec carte graphique', NULL, CAST(N'2018-12-31' AS Date), 1, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (14, 2, 0, 3, 4, NULL, 2, N'Ecrans tactiles pour salle de cours', N'Etudier et mettre en place une solution d''écrans tactiles pour les salles de cours
', NULL, CAST(N'2019-12-31' AS Date), 0, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (15, 10, 0, 3, 4, 0, 2, N'Notebook pour l''ICT', N'Prévoir l''achat et la mise en service de quelques notebook (comme notebooks de direction). Ils seront utiles pour le dépannage de l''infrastructure VDI en cas de panne.

Ce projet est intégré dans le projet #55 (Migration Windows 10 et Office 2016)', NULL, CAST(N'2018-12-31' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (16, 10, 1, 3, 6, 0, 2, N'Augmentation du débit de la ligne internet', N'Prévoir une éventuelle augmentation du débit de la ligne internet. Ce projet sera à determiner lors la réalisation et la mise en service du futur portail client.

--> WUM / 24.08.2018 : suite à un changement de technologie, Swisscom nous a proposé un débit 2x plus élevé pour un prix menusel 25% plus bas.', NULL, CAST(N'2019-12-31' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (17, 1, 0, 4, 5, NULL, 2, N'Tâches planifiées sur les serveurs', N'Faire la liste des tâches planifiées sur les serveurs / applications et définir des plages horaires pour répartir la charge et les IO''s.
', NULL, CAST(N'2019-12-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (18, 7, 2, 3, 13, 3, 2, N'SAP-GIS électricité', N'Projet d''intégration SAP-GIS pour l''électricité
', CAST(N'2019-12-01' AS Date), CAST(N'2020-12-30' AS Date), 20, 0, 20, 0, 0, 50, 10, 0, N'Interface GIS - SAP sera planifiée et réalisée après le feu vert de la comptabilité. 
Aucune tâche pour l''instant.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (19, 10, 12, 3, 7, 2, 2, N'Update Cobra', N'Mise à jour de la nouvelle version sur les postes clients et réinstallation du serveurs sur un Windows Server 2016', NULL, CAST(N'2019-09-06' AS Date), 3, NULL, NULL, NULL, NULL, 83, 2.5, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (20, 10, 1, 3, 11, 1, 2, N'Redondance pour la centrale téléphonique', N'Nouveau projet de mise en place d''une solution de secours Unify physique X ?  Virtuelle ? Business Number ?
', CAST(N'2019-12-01' AS Date), CAST(N'2019-12-31' AS Date), 5, 0, 0, 0, 5, 10, 0.5, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (21, 1, 0, 3, 6, NULL, 2, N'Haute disponibilité pour Fortiweb', N'Etudier si la haute disponibilité est nécessaire ou pas pour le Fortiweb. Ce projet est lié au future portail web.', NULL, CAST(N'2019-12-31' AS Date), 0, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (22, 1, 6, 2, 8, NULL, 2, N'3ème site ICT à Madretsch', N'Lorsque le local informatique de Madretsch sera déplacé dans le nouveau Data.Hub, les locaux pourront être utilisés pour accueillir le 3e site qui se trouve actuellement à Werkhof.', NULL, CAST(N'2019-06-30' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (23, 10, 11, 3, 5, 1, 2, N'Update Webgis', N'Update de WebGis et migration sur Windows Server 2016
', NULL, CAST(N'2019-07-31' AS Date), 3, NULL, NULL, NULL, NULL, 183, 5.5, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (24, 10, 1, 3, 3, 0, 2, N'Engagement d''un chef de projet', N'Gérer les entretiens et choisir le meilleurs candidat', NULL, CAST(N'2019-06-30' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (25, 10, 0, 3, 5, 0, 2, N'Portail web pour la clientèle', N'Participer à la rédaction du cahier des charges et mse en place de la solution.
Ce projet a débuté dans le cadre du projet TRIO.', NULL, CAST(N'2019-06-30' AS Date), 10, NULL, NULL, NULL, NULL, 10, 1, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (26, 10, 1, 3, 3, 1, 2, N'Concept Superuser', N'Mise en place d''un concept de SuperUser pour les applications
', NULL, CAST(N'2019-11-30' AS Date), 3, NULL, NULL, NULL, NULL, 67, 2, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (27, 10, 2, 3, 10, 3, 2, N'Update VIM 7.5', N'Planfifier et mettre en place VIM 7.5.
Remplacer les serveurs Windows 2008 R2 ICCT / ICCP / ASP / AST par 2 serveurs Windows 2016.
Installation de BCC (Business Capture Center - OpenText) en août.
Installation de AS (Archive Server) en décembre

Le projet est terminé.
Le principe des 4 yeux est à revoir. Une discussion a eu lieu pour la définition du cahier des charges mais cela fait partie d’un nouveau projet.
', NULL, CAST(N'2019-04-30' AS Date), 20, NULL, NULL, NULL, NULL, 140, 28, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (28, 10, 1, 3, 13, NULL, 2, N'Audit SAP', N'Faire un audit de l''infrastructure SAP (OS, DB, topologie)
', NULL, CAST(N'2018-07-12' AS Date), 10, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (29, 10, 2, 3, 13, 3, 2, N'Logistique - eBanf', N'Mise en place du projet de logistique avec les nouveaux scanneurs.', NULL, CAST(N'2019-08-31' AS Date), 30, NULL, NULL, NULL, NULL, 120, 36, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (30, 10, 2, 3, 13, 0, 2, N'SAP-GIS gaz & eau', N'Projet d''intégration SAP-GIS pour le gaz et l''eau.', NULL, CAST(N'2018-12-31' AS Date), 5, NULL, NULL, NULL, NULL, 100, 5, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (31, 10, 1, 3, 5, NULL, 2, N'Modem GSM pour ZFA', N'Remplacer les modems analogiques de ZFA par des modems GSM.', NULL, CAST(N'2018-07-31' AS Date), 3, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (32, 10, 2, 3, 13, 0, 2, N'ISO20022 pour le trafic de paiments', N'Mise en place d''ISO20022 pour toutes les transactions banque/poste/ESB', NULL, CAST(N'2018-07-12' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (33, 10, 2, 3, 13, 0, 2, N'Exportation des données de Seelandgas', N'Préparation migration des données Seelandgas', NULL, CAST(N'2018-08-31' AS Date), 5, NULL, NULL, NULL, NULL, 80, 4, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (34, 10, 2, 3, 13, NULL, 2, N'Rapport ELCOM pour les sites de production', N'Mise en place rapport automatique Elcom pour sites de production', NULL, CAST(N'2018-12-31' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (35, 10, 1, 1, 5, 0, 2, N'Serveurs ESX VDI', N'Achat et mise en place de 4 serveurs ESX pour l''environnement VDI.

Les ESX actuels pour l''environnement VDI seront utilisés pour l''environnement serveur, les ESX de l''environnement actuel seront mis hors service.

Ce project est lié au remplacement des équipements réseaux (switches) . Sans eux, il n''est pas possible de brancher les ESX car il n''y a pas suffisamment de ports de libre à disposition.', NULL, CAST(N'2019-03-31' AS Date), 15, NULL, NULL, NULL, NULL, 87, 13, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (36, 10, 1, 1, 5, 0, 2, N'Serveurs ESX SRV', N'Remplacement des serveurs ESX SRV par les anciens serveurs ESX VDI.
Ce projet est lié au remplacement des serveurs ESX VDI.

Les ESX actuels pour l''environnement VDI seront utilisés pour l''environnement serveur, les ESX de l''environnement actuel seront mis hors service.

Ce project est lié au remplacement des équipements réseaux (switches) . Sans eux, il n''est pas possible de brancher les ESX car il n''y a pas suffisamment de ports de libre à disposition.', NULL, CAST(N'2019-03-31' AS Date), 15, NULL, NULL, NULL, NULL, 127, 19, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (37, 10, 7, 3, 2, 0, 2, N'Contacts ESB dans Exchange', N'Mise en place de la technique et des processus de mise à jour des collaborateurs ESB dans les contacts pour Exchange / Smartphone.

Une information a été publiée sur Intranet et la solution mise en place.
Le projet est terminé (20.02.2018 / WUM)', NULL, CAST(N'2018-12-31' AS Date), 5, NULL, NULL, NULL, NULL, 20, 1, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (38, 8, 1, 3, 5, 1, 2, N'Windows Server', N'Migrer tous les serveurs Windows 2008 R2 à Windows 2016.
Solde : environ 30 serveurs à 3 jours par serveurs', CAST(N'2019-12-01' AS Date), CAST(N'2020-06-30' AS Date), 90, 80, 0, 0, 10, 35, 31.5, 0, N'Il y a encore 27 serveurs en Windows 2008 R2, certains fonctionnent à double pour les postes 
clients qui ne sont pas encore à Windows 10. ')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (39, 10, 6, 3, 5, 0, 2, N'VDI Windows 10 avec carte graphique', N'Passer de PC physiques à l''environnement virtuet pour les dessinateurs.
Idem pour l''ordinateur physique à Serge Rau (Adobe Creative Suite) --> l''ancien projet #13 est intégré dans ce projet #39

Ce projet est intégré au projet #39 (VDI Windows 10 et Office 2016)', NULL, CAST(N'2019-03-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (40, 10, 6, 3, 6, 1, 2, N'Autorisation de connexion des périphériques au réseau bureautique', N'Seuls les ports autorosés au préalable pour se connecter au réseau pourront se connecter au réseau (serveur Radius).
Les périphériques non-autorisés ne pourront plus se connecter au réseau.

Cela concerne la configuration des switches du réseau bureatique ESB (switches d''étages) et la saisie des adresses MAC des périphériques autorisés.', NULL, CAST(N'2019-06-30' AS Date), 20, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (41, 10, 3, 3, 13, NULL, 2, N'SAP-SD', N'Facturation SD ESB à ESB ', NULL, CAST(N'2018-07-12' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (42, 10, 3, 3, 2, 3, 2, N'Qlik - Mise en place de nouveaux rapports', N'Mise en place de nouveaux rapports NPrinting pour le budget ou pour les KST.
Il faut commencer par définir le cahier des charges.

Les rapports sont implémentés en externe (Informatec).
Le délai d''évaluation est de 8 jours.

Examen et mise à l''essai internes
', CAST(N'2019-12-01' AS Date), CAST(N'2019-12-31' AS Date), 10, 0, 10, 0, 0, 130, 13, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (43, 10, 3, 3, 13, 3, 2, N'Auftragabwicklung - Pilot Hausanschluss G / W', N'Projekt Auftragabwicklung, Teilprojekt : Pilot Hausanschluss G/W
Auftragabwicklung - Optimierung Datenqualität

Auftragabwicklung - Pilot Hausanschluss G / W
-Formulare entwickeln
-Prozessmodelierung
-Customizing
', NULL, CAST(N'2019-09-30' AS Date), 30, NULL, NULL, NULL, NULL, 73, 22, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (44, 10, 3, 3, 15, 0, 2, N'Formulaires Inkasso (eSchKG)', N'SAP-ASEM Formulaires Inkasso (eSchKG) pour les poursuites en remplacement de Cash-In', NULL, CAST(N'2019-01-31' AS Date), 10, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (45, 10, 2, 3, 13, 0, 2, N'eBanf', N'Mise en place et formation sur eBanf, pour les commandes électroniques', NULL, CAST(N'2018-12-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (46, 10, 1, 3, 5, 0, 2, N'Archivage des activités et des projets', N'Archivage des projets et des activités depuis le serveur de fichiers sur un serveur d''archive.
L''objectif est de libérer de la place sur le serveur de fichiers.

Le concept est mis en place, l''archivage devient une tâche courante opérationnelle.
Fin du projet (WUM / 20.02.2019)', NULL, CAST(N'2019-02-28' AS Date), 3, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (47, 10, 6, 3, 5, 0, 2, N'Nouveau serveur Windows Update WSUS', N'Mise en place et configuration d''un nouveau serveur WSUS pour Windows 2016', NULL, CAST(N'2019-03-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (48, 10, 7, 3, 4, 0, 2, N'Barco clickshare', N'Mettre en place une solution Barco clickshare pour les salles de séances.

Le système Barco ClickShare est installé dans toutes les salles.', NULL, CAST(N'2019-01-31' AS Date), 3, NULL, NULL, NULL, NULL, 300, 9, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (49, 10, 1, 3, 3, 0, 2, N'Budget 2019', N'Veuillez trouver ci-joint les différentes échéances pour le budget 2019. Les délais découlent de la séance du VR fixée au 20 novembre 2018 pendant laquelle le budget est présenté.

Les responsables de centre de coûts pris en compte pour le budget vont recevoir d’ici le 31 août les données actuelles cumulées à juin 2018 ainsi qu’une proposition de budget.
Une fois cette proposition modifiée et validée, elle doit être retournée au controlling par email jusqu’au 28 septembre 2018 au plus tard.', NULL, CAST(N'2018-09-28' AS Date), 5, NULL, NULL, NULL, NULL, 40, 2, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (50, 10, 1, 3, 4, NULL, 2, N'Imprimante Zebra', N'Mettre en place et installer l''imprimante Zebra sur le PC pour le metering', NULL, CAST(N'2018-07-31' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (51, 10, 10, 3, 6, NULL, 2, N'Access Point', N'Mettre en place les nouvelles antennes 
OK dans le bâtiment.
Manque 2 antennes extérieures (Kabelhalle)', NULL, CAST(N'2018-07-17' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (52, 10, 1, 2, 11, 1, 2, N'Central téléphonique', N'Correction des problèmes de jeunesse et terminer les problèmes en cours
Tranmission opérationnelle au team Helpdesk & Applications.

Le système est stable depuis l''application du patch

La centrale téléphonique n’est plus un projet et devient opérationnelle.', NULL, CAST(N'2019-05-31' AS Date), 20, NULL, NULL, NULL, NULL, 95, 19, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (53, 10, 8, 3, 3, 0, 2, N'IT-Board', N'Définir et mettre en place l''IT-Board
', NULL, CAST(N'2018-08-30' AS Date), 2, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (54, 10, 8, 2, 3, 1, 2, N'Stratégie IT Phase 2', N'Mettre en place la phase 2 de la stratégie IT avec AWK et le département B.
Cette phase 2 de la stratégie IT se termine avec la fin du mandat donnée à AWK.

Le mandat avec AWK s''est terminé fin 2018, le projetest terminé (WUM / 20.02.2019)', NULL, CAST(N'2019-01-31' AS Date), 10, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (55, 8, 6, 2, 7, 1, 2, N'Migration Windows 10 et 
Office 2016', N'Migration des postes de travail Windows 10 et Office 2016.
GOA : environ 1 jour pour installation (virtualisation) de chaque application (80 applications) = 80 jours
HOT : environ 10 jours pour aider
JET / DOD : environ 20 jours chacun pour UEM et paramétrages des applications
WUM : environ 5 jours de coordination

Les projets #13 (PC Serge Rau), #39 (VDI Windows 10 avec carte graphique), #15 (Notebook pour l''ICT) sont intégrés dans ce projet.

La migration va commencer en mars pour se terminer à la fin de l''année.', CAST(N'2019-12-01' AS Date), CAST(N'2020-06-30' AS Date), 147, 125, 0, 12, 10, 100, 147.5, 0, N'Gemäss Entscheid IT-Board vom 23.03.2020 wird das Projekt Migration Windows 10 bis Ende Junil verlängert werden.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (56, 10, 1, 2, 5, 1, 2, N'MDM (Airwatch) Workspace One', N'Mettre en place un outil de gestion des périphériques mobiles (Airwatch) ainsi que les stratégies de sécurité.

Le concept de téléphonique mobile est intégré au projet MDM Airwatch parce qu''il dépend directement du projet.', NULL, CAST(N'2019-09-30' AS Date), 30, NULL, NULL, NULL, NULL, 120, 36, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (57, 10, 1, 2, 8, 1, 2, N'Data.Hub / DC.One', N'Déménager le centre de calcul de Madrestsch chez Data.Hub / DC.One', NULL, CAST(N'2019-05-31' AS Date), 20, NULL, NULL, NULL, NULL, 132, 26.5, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (58, 10, 1, 1, 6, 1, 2, N'Remplacement de tous les switches', N'Remplacement de tous les switches à Gottstatt et chez Data.Hub / DC.One.

Ce projet est lié au remplacement des ESX ainsi qu''au déménagemetn du centre de calcul de Madretsch dans le nouveau Data.Hub', NULL, CAST(N'2019-05-31' AS Date), 20, NULL, NULL, NULL, NULL, 130, 26, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (59, 10, 1, 3, 3, NULL, 2, N'Renouvellement licences Microsoft', N'Renouveller les licences pour les produits Microsoft, à savoir :
- VDA Windows 10
- Office 2016
- Visio 2016
- Project 2016
- Exchange 2016
- CAL user / device', NULL, CAST(N'2018-07-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (60, 10, 1, 1, 6, 2, 2, N'Transformation du réseau RTEC', N'Participer à la migration de RTEC vers une nouvelle infrastructure.
Adaptation au niveau des firewalls Fortigate

Collaboration avec BBS au nouveau concept VLAN et adressage IP, de la nouvelle topologie et de l''achat des nouveaux switches / firewalls
', NULL, CAST(N'2019-08-31' AS Date), 20, NULL, NULL, NULL, NULL, 270, 54, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (61, 10, 1, 1, 5, 1, 2, N'Mise en place des serveurs auxiliaires', N'Mise en place des serveurs auxiliaires dans le réseau RTEC.
Le projet ELS sera le premier "client" de ces serveurs.', NULL, CAST(N'2019-08-31' AS Date), 10, NULL, NULL, NULL, NULL, 250, 25, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (62, 1, 2, 3, 14, 0, 2, N'Interface SAP - Froeschl', N'Optimisation de l''interface SAP-Froeschl (ZFA)', NULL, CAST(N'2019-12-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (63, 10, 6, 2, 5, 1, 2, N'Migration de la DMZ', N'Transformer la partie DMZ du réseau et l''intégrer dans un/des VLAN séparés dans le LAN.

La mise en place est terminée', NULL, CAST(N'2019-03-31' AS Date), 5, NULL, NULL, NULL, NULL, 60, 3, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (64, 5, 0, 4, 4, NULL, 2, N'Legamaster pour les salles de cours', N'Evaluer, choisir et mettre en place des écrans tactiles pour salle de cours', NULL, CAST(N'2019-12-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (65, 10, 2, 3, 15, NULL, 2, N'Optimisation Processus Zählerscheine', N'Optimisation Processus Zählerscheine
', NULL, CAST(N'2019-12-31' AS Date), 3, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (66, 10, 3, 3, 5, 3, 2, N'Update Qliksense / Qlikview / Nprinting (nouveaux serveurs & nouvelles versions des applications)', N'Update des logiciels suivants : Qliksense / Qlikview / Nprinting
Remplacement des serveurs par des serveurs Windows 2016', NULL, CAST(N'2019-07-31' AS Date), 15, NULL, NULL, NULL, NULL, 113, 17, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (67, 10, 6, 3, 5, 0, 2, N'Update MoveIT DMZ', N'Update de MOVEit DMZ Enterprise 8.3.0.30 en MOVEit 2018 SP1.
Remplacement du serveur par Windows serveur 2016

MOVEit Transfer (MOVEit DMZ) End of Life : 10/1/2019  

Cette tâche est intégrée dans la maintenance "normale" de l''infrastructure.', NULL, CAST(N'2019-03-31' AS Date), 5, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (68, 10, 1, 2, 11, 1, 2, N'Enregistreur ASC EVOIP', N'Mettre en place un serveur ASC EVOIP pour l''enregistrement des conversations du service à la clientèle.
Ce projet dépend de la mise en service des core switches et des switches d''étage.', CAST(N'2019-12-01' AS Date), CAST(N'2020-03-31' AS Date), 10, 10, 0, 0, 0, 150, 15, 0, N'Gemäss Entscheid IT-Board vom 23.03.2020 kann das Projekt Enrigistreur ASC geschlossen werden')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (69, 10, 2, 2, 13, 3, 2, N'Remise en état de la gestion du stock des compteurs', N'Définition correctes des stocks pour éviter que les compteurs apparaissent dans le bilan sous le stock et les imoobilisations', NULL, CAST(N'2019-12-31' AS Date), 10, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (70, 10, 0, 3, 7, 0, 2, N'Update ZFA', N'Installation du serveur sur un nouveau serveur Windows Server 2016.
Déplacement de la base de données SQL du SQL-serveur 2014 sur le SQL-Server 2016 Always On
Refaire le paquet pour la distribution client.

La mise à jour se déroulera du 15 au 17 janvier 2019.

Un problème de DB a repoussé l''installation au lundi 18 février 2019.

L''update est terminé ( WUM / 20.02.2019)', NULL, CAST(N'2019-01-31' AS Date), 5, NULL, NULL, NULL, NULL, 80, 4, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (71, 10, 10, 3, 13, 0, 2, N'Solution Manager Update', N'Update stack V4 à V7 --> nécessaire pour la mise à jour de HR-Patch fin 2018', NULL, CAST(N'2018-11-30' AS Date), 3, NULL, NULL, NULL, NULL, 233, 7, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (72, 10, 10, 2, 13, 0, 2, N'Update NetWeaver & HR Patch', N'Update NetWeaver 7.4 sur et mise à jour des pathches HR 2019 sur les ERP
(SAP PROD / DEV / TEST)

Le projet est terminée (WUM / 20.02.2019)', NULL, CAST(N'2018-12-31' AS Date), 10, NULL, NULL, NULL, NULL, 90, 9, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (73, 7, 2, 3, 13, 3, 2, N'ISO20022 BVR avec QR-Code', N'Mise en place d''ISO20022 pour toutes les transactions banque/poste/ESB

Ce projet intègre le projet #74 (Remplacement LaserSoft) --> Facture emotionelle, redesign des layouts des factures, remplacement de l''outil LaserSoft.', CAST(N'2019-12-01' AS Date), CAST(N'2020-12-31' AS Date), 15, 0, 15, 0, 0, 0, 0, 0, N'Sera planifié ultérieurement ')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (74, 10, 0, 2, 13, 0, 2, N'Remplacement LaserSoft', N'Facture emotionelle, redesign des layouts des factures, remplacement de l''outil LaserSoft

Ce projet est intégré dans le projet #73 (ISO20022 BVR avec QR-Code)', NULL, CAST(N'2019-12-31' AS Date), 30, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (75, 7, 3, 2, 10, 4, 2, N'Kundenportal für Marketing', N'Kundenportal für Marketing
Erstellung des Pfichtenheftes.

2. Phase : 
Implementation & Workshops Use Cases', CAST(N'2019-12-01' AS Date), CAST(N'2020-07-31' AS Date), 35, 0, 30, 0, 5, 81, 28.5, 0, N'Les connexions techniques sont en place, les fonctionnalités compris dans Rel.1 et 2 sont 
actuellement mis en place. Premiers Workshops de test sont prévus pour KW6. ')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (76, 1, 2, 3, 1, NULL, 2, N'CRM', N'', NULL, CAST(N'2019-12-31' AS Date), 0, NULL, NULL, NULL, NULL, 0, 0, 0, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (77, 10, 11, 1, 5, 0, 2, N'Réinstallation VeeamOne', N'Réinstallation VeeamOne suite au crash et la corruption de la base de données.

Le projet est terminé ( 20.02.2019 / WUM)', NULL, CAST(N'2019-02-28' AS Date), 4, NULL, NULL, NULL, NULL, 50, 2, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (78, 10, 12, 3, 10, 5, 2, N'Digitalisation des e-dossiers du personnel', N'Mise en place de la solution "Next" de "Confer"

Estimation des ressources : 5 jours pour générer le fichier XML, 5 jours pour la mise en place du ADFS (SSO)', NULL, CAST(N'2019-07-31' AS Date), 10, NULL, NULL, NULL, NULL, 100, 10, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (79, 10, 2, 3, 13, 3, 2, N'VIM : modification de la validation des 4 yeux', N'', NULL, CAST(N'2019-08-31' AS Date), 0, NULL, NULL, NULL, NULL, 0, 0, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (80, 10, 12, 3, 1, 2, 2, N'Mitarbeiterverzeichnis im Intranet und im Outlook ', N'Mettre une solution en place pour la synchronisation des données entre SAP / Outlook / Intranet', NULL, CAST(N'2019-08-31' AS Date), 5, NULL, NULL, NULL, NULL, 10, 0.5, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (81, 10, 6, 1, 1, 1, 2, N'Certificat - Wildcard SSL', N'Il est nécessaire de renouveler les certificats existants.
-inventaire
-Rendez-vous avec un consultant externe
', NULL, CAST(N'2019-05-27' AS Date), 6, NULL, NULL, NULL, NULL, 67, 4, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (82, 10, 2, 2, 1, 1, 2, N'Auftragabwicklung - Pilot Hausanschluss G / W', N'Auftragabwicklung - Pilot Hausanschluss G / W
-Formulare entwickeln
-Prozessmodelierung
-Customizing

Doppelerfassung : siehe #43', NULL, CAST(N'2019-05-27' AS Date), 9, NULL, NULL, NULL, NULL, 83, 7.5, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (83, 7, 2, 2, 13, 1, 2, N'SAP S/4 HANA - 99900.200005', N'Redesign ERP
Evaluation ERP', CAST(N'2019-12-01' AS Date), CAST(N'2020-12-01' AS Date), 200, 0, 100, 0, 100, 41, 82, NULL, N'Das Projekt ERP Evaluation geht in die entscheidende Runde.
Die Nutzwertanalyse konnte im Kernteam nun mehrfauch ausgiebig besprochen werden, was wichtig und nötig war.
Aktuell sind von Seite Kernteam keine Fragen mehr offen.
Auf den Input von Adrian und Gregory wird nun für die Systeme SAP S/4 HANA sowie Abacus / is-e angefragt für eine Demo-Umgebung auf welcher sich definierte Kernteams anhand von Use Cases ein vertieftes Bild der jeweiligen ERP-Lösungen machen können.
')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (84, 10, 13, 1, 13, 6, 2, N'Libéralisation - Marché du gaz', N'Préparation de SAP en vue d''une libéralisation chaotique du marché du gaz', NULL, CAST(N'2019-07-16' AS Date), 20, NULL, NULL, NULL, NULL, 15, 3, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (85, 10, 11, 3, 5, 6, 2, N'Update CareOffice', N'Mettre à jour CareOffce
Mise à jour de l''application serveur
Mise à jour des applications mobiles

Avec le soutien de Christophe & David', NULL, CAST(N'2019-09-30' AS Date), 6, NULL, NULL, NULL, NULL, 83, 5, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (86, 10, 2, 2, 13, 1, 2, N'SAP Migration - Systeme Wechsel - HW und DB', N'AP 1 für Koordination, Konzept, Planung, Dokumentation
AP 2 für System ET1 
AP 3 für System EI1 
AP 4 für System EP1 (produktive Umgebung) 
AP 5 für System PIT 
AP 6 für System PIP (produktive Umgebung) 
AP 7 für System SME (Solution Manager) 
AP 8 für System Content Server (1 Systemumgebung) 
AP 9 für System Web Dispatcher (1 Systemumgebung)', CAST(N'2019-12-01' AS Date), CAST(N'2020-02-29' AS Date), 13, 10, 3, 0, 0, 104, 13.5, NULL, N'Gemäss Entscheid IT-Board vom 23.03.2020 wird das Projekt SAP Migration geschlossen.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (87, 7, 3, 3, 1, 6, 2, N'Optimierung / Korrekturen Projektreporting Qlik', N'Beschreibung des Problems
-	Wertvernichtung wird nicht korrekt ausgewiesen (Ticket 7308)
-	Das Total der Materialkosten wird nicht mehr angezeigt
-	Übermittlung von Bridge-Kommentaren ins Projektreporting, was dazu führt dass Stunden eines Projektmitarbeiters in mehrere Zeilen aufgeteilt werden (eine pro Kommentar)
-	Abweichungen von Materialkosten/Obligos/IST-Kosten verursacht durch die Verwendung neuer Belegarten in SAP, welche in Qlik nicht definiert sind, oder via Schnittstelle nicht übergeben werden
Beschreibung des Bedarfs
-	Sämtliche neu hinzugekommenen Belegarten sind über die Schnittstelle an QlikView zu liefern.
-	Das Reporting muss dahingehend korrigiert werden, dass keine Inkonsistenzen zwischen den heute verwendeten SAP-Reports und QlikView mehr bestehen.

Lösungsansatz
-	Anpassung bzw. Erweiterung diverser QlikView-Codes und Darstellungen
-	Überprüfung der heutigen Schnittstelle Bridge – SAP – Qlik und Lösungsvorschlag bzgl. Bridge-Kommentare
-	Definition der fehlenden Belegarten
-	Überprüfung des bestehenden Codings und Abgleich mit der in SAP verwendeten Logik', CAST(N'2019-12-01' AS Date), CAST(N'2020-06-30' AS Date), 2, 0, 2, 0, 0, 325, 6.5, NULL, N'Gemäss Entscheid IT-Board vom 20.04.2020 wird das Projekt bis Ende Juni verlängert werden.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (88, 10, 12, 1, 1, 1, 2, N'Evaluierung Ersatz MFP', N'Es wird geprüft ob und wie die bestehenden Etagen MFP ersetzt werden können.
', CAST(N'2019-12-01' AS Date), CAST(N'2019-12-31' AS Date), 10, 1, 0, 1, 8, 95, 9.5, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (89, 10, 12, 2, 2, 1, 2, N'Evaluierung Collaboration-Tool', N'Im Auftrag des IT-Boards soll ein Collaboration-Tool evaluiert werden.
Folgende Funktionen muss das Tool enthalten.
-FileSharing
-Kollaboration Funktionen

Arbeitspakete:
-Eruieren der detaillierten Anforderungen
-Evaluieren einer oder mehrer geigneter Lösungen
-Variantenwahl / Emfpehlung
-Grobplanung für mögliche Umsetzung', NULL, CAST(N'2019-11-04' AS Date), 7, NULL, NULL, NULL, NULL, 79, 5.5, NULL, NULL)
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (90, 10, 1, 1, 5, 7, 2, N'Remplacement du système de stockage', N'Mettre en service le nouveau système de stockage HPE Nimble', CAST(N'2019-12-01' AS Date), CAST(N'2020-03-31' AS Date), 5, 4, 0, 0, 1, 130, 6.5, NULL, N'Gemäss Entscheid IT-Board vom 23.03.2020 wird das Projekt Remplacement du systeme de stockage geschlossen werden')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (91, 8, 1, 1, 6, 2, 2, N'Sonde Radioaktivitätsmessung für SWW', N'Für die Messung der Radioaktivität wird im SWW Ipsach eine Sonde verbaut.
Diese muss ins RTEC Netz der ESB integriert werden.
-Bereitstellen Envinet-Server
-Einrichten ganzes System
-Testing', CAST(N'2019-12-01' AS Date), CAST(N'2020-07-31' AS Date), 5, 2, 0, 0, 3, 10, 0.5, NULL, N'Gemäss Entscheid IT-Board vom 20.04.2020 wird das Projekt bis Ende Juli verlängert werden.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (92, 10, 1, 1, 1, 1, 2, N'Rollen u. Verantwortlichkeiten überarbeiten', N'Das bestehende Dokument Rollen u. Verantwortlichkeiten ist gemäss den neusten Erkenntnissen aus dem für die Migration erstellten Super-User Konzept anzupassen.', CAST(N'2019-12-01' AS Date), CAST(N'2020-02-29' AS Date), 3, 0, 0, 0, 3, 67, 2, NULL, N'Gemäss Entscheid IT-Board vom 23.03.2020 kann das Projekt Rollen u. Verantwortlichkeiten geschlossen werden
')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (93, 8, 12, 2, 2, 7, 2, N'Collaboration-Tool Pilotphase - 99900.200006', N'Das IT-Board hat den Vorschlag angenommen für das evaluierte FileShare und Collaboration-Tool "NextCloud" eine Pilotphase zu starten.
-Bereitstellen Infrastruktur NextCloud Umgebung
-Testing auf Basis der durch die in der Evaluationsphase eruierten Bedürfnisse

Parallel dazu wird in zweiter Priorität für Sharepoint und Confluence eine Offerte auf Basis eines Lastenheftes eingeholt, um zu verstehen was eine Sharepoint bzw. Confluence Landschaft in der ESB für Aufwände und Kosten generieren würde.
Dies mit Sinn und Zweck, sollte sich in Zukunft an den Bedürfnissen etwas ändern (Stichwort Evaluation ERP System).', CAST(N'2019-12-01' AS Date), CAST(N'2020-06-30' AS Date), 10, 5, 0, 0, 5, 115, 11.5, NULL, N'Installation gemäss Vorgaben (Projektantrag) konnten durch Adfini Sy Group erfolgreich umgesetzt werden.
Das IT Infrastruktur Team hat noch Abklärungen bzw. Feinjustagen hinsichtlich Integration in unser FileSystem zu machen.
Grundsätzlich ist das Projekt gemäss Projektplanung auf Kurs, kam aber durch Corona nun in Verzug und muss um einen Monat verschoben werden.
Nach der Freigabe durch die IT Infrastruktur kann mit dem effektiven Testing mit den Testequipen begonnen werden.
Die Testequipen sind klar und konnten bereits angegangen werden.
Folgende Test-Teams sind angedacht:
-	Seewasserwerk-Projekt Team
-	Marketing (Martin Kamber, Serge Rau) für Ablösung Trello (Kanban-Board)
-	Davide Crotta (Engineering) für generelle Abläufe, Projektstrukturen, Filesharing.
Testszenarios und Anleitung in Finalisierung.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (94, 10, 2, 2, 13, 3, 3, N'Reprise gestion de stock nouveaux compteurs G/W/E', N'Mise en place SAP pour la reprise des nouveaux compteurs G/W/E pour ESB ainsi que Nidau et matériels Metering qui n’est pas encore en stock.
Nettoyage de la base de données, création de nouveaux articles, mise en place de processus, définition des comptes et processus finan-ciers
', CAST(N'2019-12-01' AS Date), CAST(N'2020-02-29' AS Date), 10, 0, 10, 0, 0, 60, 6, NULL, N'Kann gemäss IT-Board vom 24.02.2020 geschlossen werden.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (95, 7, 3, 1, 1, 4, 2, N'SAP Reports für Kundenmanagementkonzept', N'Das Kundenmanagementkonzept wurde erstellt und kommuniziert. Damit dieses in Zukunft umgesetzt und die darin enthaltenen Ansätze gesteuert werden können, müssen die nötigen Reports im SAP erstellt werden. Es handelt sich dabei um Reports, welche Auswertungen basierend auf den vier Kunden-/Partnerklassen (Platin, Gold, Silber, Bronze) ermöglichen. Die Reports sollen in der operativen Arbeit die Datengrundlage bieten um Entscheidungen/Massnahmen im Kun-denmanagement zu treffen.', CAST(N'2019-12-01' AS Date), CAST(N'2020-06-30' AS Date), 5, 0, 5, 0, 0, 140, 7, NULL, N'Gemäss Entscheid IT-Board vom 20.04.2020 wird das Projekt bis Ende Juni verlängert werden.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (96, 8, 12, 2, 1, 7, 1, N'Pilotphase Ersatz MFP / Rollout MFP - 46000292', N'Das IT Board hat den vorschlag grundsätzlich angenommen.
Die Lieferantenwahl «Canon » wurde angenommen, die Variante 1 wurde nur bedingt als gut empfunden.

Das IT Board entscheidet sich für einen Kauf der Geräte von Canon will jedoch zuerst eine Testphase mit einem Gerät durchführen, Wird dieser erfolgreich, können die weiteren 3 MFP’s bestellt werden.

Für die bestehenden Bürodrucker soll mit Itris ein Wartungsvertrag auf Basis der im Vorfeld eingeholten Offerte abgeschlossen werden.
Die Variantenwahl muss nochmals durchdacht werden, das IT Board will in den Büros in denen viel auf den Bürodruckern gedruckt wird die Drucker zwar stark reduzieren aber jeweils ein Gerät stehen lassen.', CAST(N'2019-12-12' AS Date), CAST(N'2020-05-31' AS Date), 8, 4, 0, 2, 2, 194, 15.5, NULL, N'Interne (IT) Geräte Tests erfolgreich.
Quick Guide erstellt
Anleitung erstellt
Information an ESB Mitarbeiter per Intranet Newsletter erfolgt
Dokumente auf Intranet abgelegt
Projektverzögerung durch Corona, Einführung muss um einen Monat verschoben werden.
Die wenigen Feedbacks der Mitarbeiter sind sehr positiv.
-> uns wäre hier sehr wichtig von Seite IT-Board ein Feedback hierzu zu erhalten!
Empfehlung an IT-Board:
Grundsätzlich wurde genug getestet, die neuen MFP’s können nun bestellt werden
')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (97, 7, 2, 2, 13, 7, 2, N'Mise à jour du module IDEX-CH2', N'Gemäss IT-Board Antrag vom 09.09.2019

Les exigences de l''AES et de Swissgrid pour les acteurs du marché de l''énergie sont en constante évolution. Actuellement les deux organismes poussent vers une digitalisation standardisée des transferts de données. 
Ces transferts concernent les échanges de données de quantités (profil de charge ou/et valeurs discrètes), des messages de quantités issues des rapprochements "Bilanzierung", des messages de changements de fournisseurs, de fin de fourniture, et autres processus de changement, et à l''avenir ces transferts standardisés vont aussi concerner les demandes d''informations.
Les recommandations de la branche rédigées par l''AES, pour les processus du marché et les structures de données qui n''étaient jusqu''à présent que de simples recommandations, vont devenir plus contraignantes pour tous les acteurs de marché. En effet on s''achemine vers une obligation d''application et d''utilisation de ces règles et de digitalisation des échanges de données.
Notre version IDEX-CH1 avait été mise en place en 2008 sur la base des exigences de l''époque. Cette version est maintenant arrivée en bout de course. 
A l''époque le développement avait été fait par néo-technologies en collaboration avec SAP et différents GRD Suisse dont ESB. Il s''agit donc d''un Add-on spécifique supporté et développé par néo-technologies. ESB est actuellement le dernier client à utiliser encore cet Add-on. C''est Add-on n''est plus supportée et n''est pas compatible avec une évolution des autres modules SAP.
Le nouveau logiciel IDEX-CH2 est quant à lui un tout nouveau produit, 100% de propriété et de développement SAP. Il se base sur les expériences acquises par SAP dans les différents marchés de l''énergie européennes (dont ils ont repris en partie le fonctionnement des processus de masse automatisés) et ont intégré ensuite les spécificités du marché Suisse. Dans le futur, ce module SAP va évoluer parallèlement aux autres produits SAP et sa compatibilité avec les mises à jour sera garantie par SAP.
Même si les 2 modules CH1 et CH2 sont installés dans SAP, le passage entre IDEX-CH1 et IDEX-CH2 n''est pas une simple mise à jour mais une migration d''une solution à une autre. 
Pour installer CH2 il faudra d''abord détruire CH1, pour cette raison néo conseille de travailler avec un bac à sable (copie du productif) pour le paramétrage et les tests de migrations, ceci pour garder les systèmes ET1 > EI1 > EP1 intactes. Ensuite seul le delta sera transporté ou copié. 
Fonctionnalité:
•	Il s''agit avant tout d''un remplacement technique sans mise en place de fonction supplémentaire
•	Descriptif des paquets néo pour IDEX-CH2
Rapprochement (Bilanzierung) = P1 
pas de changement mais séparation entre calcul et envoie des messages E31
Envoie des valeurs pour E66 et pour E31  = P2
Envoie des changements (plus possible si pas mis à jour)   = P3
•	IDEX-CH2 prévoit la séparation des envois des sommes E31 du calcul de rapprochement Bilanzierung. Aujourd''hui chaque rapprochement juste ou faux est transmis automatiquement à tous les acteurs de marchés. Pas possible d''empêcher l''envoi des erreurs.', CAST(N'2020-03-01' AS Date), CAST(N'2020-10-31' AS Date), 20, 0, 20, 0, 0, 18, 3.5, NULL, N'La planification est en cours avec Neo. Les travaux débuteront début mai 2020pour se terminer fin 
novembre 2020.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (98, 10, 1, 1, 5, 7, 2, N'Kaba - Update/Migration', N'Vorbereitung Kaba Server
Remote Installation Kaba
Update AML und andere Gerät (Kaba in ESB)
Reserve Remote Installation
Migration Datenbank
', CAST(N'2019-12-19' AS Date), CAST(N'2020-03-31' AS Date), 5, 5, 0, 0, 0, 110, 5.5, NULL, N'Gemäss Entscheid IT-Board vom 23.03.2020 kann das Projekt KABA Update geschlossen werden')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (99, 10, 6, 2, 8, 8, 2, N'Adaptations et modifications RTEC après SAT I / SAT II IDS', N'Adaptations et modifications suite aux SAT I et SAT II qui se sont déroulés avec IDS.
La liste détaillée sera mise à disposition par Nathalie / BBS.', CAST(N'2019-12-19' AS Date), CAST(N'2019-12-19' AS Date), 10, 10, 0, 0, 0, 0, 0, NULL, N'Les modifications sont effectuées durant la semaine 4. ')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (100, 10, 2, 1, 18, 7, 3, N'ZEV-Tarife für Nidau - 99900.200007', N'Mit dem Produkt Inter-PV hat der ESB ein sehr kundenfreundliches Produkt lanciert, welches die Abbildung von ZEV im SAP-System und unter Verwendung der bestehenden ESB-Zähler ermöglicht. Als Folge können die ZEV-Mitglieder in der Grundversorgung und damit als ESB-Kunden gehalten werden. 
Aufgrund der Tatsache, dass der ESB als Dienstleister die Verrech-nung auch in Nidau macht, wurde Nidau angeboten, das Produkt auch für Nidau umzusetzen (gegen eine Einmalgebühr, sowie wieder-kehrende Kosten).
Um dies nun umzusetzen, sind die ZEV-Tarife für Nidau im SAP zu programmieren, sodass zukünftige ZEVs in Nidau über den ESB abge-wickelt werden können
Ohne entsprechende Programmierung können die ZEVs in Nidau nicht realisiert werden.
', CAST(N'2020-01-30' AS Date), CAST(N'2020-02-29' AS Date), 5, 0, 5, 0, 0, 250, 12.5, NULL, N'Gemäss Entscheid IT-Board vom 20.04.2020 wird das Projekt geschlossen')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (101, 8, 2, 2, 18, 7, 3, N'SAP Verrechnung von Ladestrom auf Stromrechnung - 91800.200001', N'Aufgrund der Produkteinführung Ladeinfrastruktur «Halb-öffentlich / halb-privat» und der dazugehörigen Abrechnungs- und Verwaltungsdienstleistungen, sollte der ESB parat sein diese systemtechnisch abzubilden.

Dafür benötigt es eine SAP Programmierung sowie eine systemtechnische Anbindung an das heutige Ladeinfrastruktur-Backend. 

Die IT programmiert die Ladestromverrechnung im SAP und baut die notwendige Schnittstelle. ', CAST(N'2020-01-30' AS Date), CAST(N'2020-07-31' AS Date), 10, 0, 10, 0, 0, 0, 0, NULL, N'Gemäss Entscheid IT-Board vom 20.04.2020 wird das Projekt bis Ende Juli verlängert werden.')
GO
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (102, 8, 1, 2, 4, 7, 2, N'Notebook/iPad ESB - Aufstockung - 46000293', N'Remplacer et réinstaller les notebooks de direction.
Modificer la connexion VPN à l''infrastructure.
L’IT-Board accepte d’équiper les collaborateurs ESB avec 50 note-
books et 31 iPads et libère un crédit unique de 232’680.00 CHF 
ainsi que des coûts réccurents (OPEX) de 23''500.00 CHF / année.', CAST(N'2020-01-12' AS Date), CAST(N'2020-06-30' AS Date), 33, 30, 0, 3, 0, 32, 10.5, NULL, N'')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (103, 2, 8, 2, 1, 2, 2, N'Realisierungneues SWW', N'Projekt wurde auf Wunsch von Res Hirt bereits im Tool erfasst.
Weitere Informationen folgen per Herbst 2020.', CAST(N'2020-08-30' AS Date), CAST(N'2025-12-01' AS Date), 60, 45, 0, 0, 15, 0, 0, NULL, N'Projekt wurde auf Wunsch von Res Hirt bereits im Tool erfasst.
Weitere Informationen folgen per Herbst 2020.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (104, 8, 14, 3, 1, 7, 2, N'Migration RTec Netzwerk', N'Das Ziel des Projektes ist, die Migrationsplanung für das RTec 
Netzwerk zu erstellen. Jedes der über 400 Endgeräte muss vor Ort 
manuell umkonfiguriert werden.
Die Migration des Netzwerks bringt folgende Arbeiten mit sich: 
? Konzept Topologie prüfen / ergänzen 
? Distributionsstandorte validieren 
? Hardware Evaluation und Definition 
? Firmware prüfen und Grundsatzentscheid (AOS8, 
AOS8/AOS6) 
? Interconnection der beiden Netzwerke (RTec alt / neu) 
? Prüfung der Stationen und aufzeigen des Handlungsbe-


 

Energie Service Biel/Bienne 
Gottstattstrasse 4, rue de Gottstatt · Postfach / CP 4263 · 2500 Biel/Bienne 4 
T 032 321 12 11 · www.esb.ch 

darfs (Investition in Infrastruktur, USV, etc.) 
? Stromversorgungskonzept Switches Wasserstationen 
? Sofern notwendig: Klärung der Blackbox-Netzwerke von IDS 
? Prüfung und Empfehlung Ersatz Blackbox-Netzwerke von 
IDS 
? Entscheidungsgrundlage für Migrationsplan erstellen 
? Migrationsgrundlage mit diversen Herstellern erarbeiten 
(Tebicom, IDS, ABB, Siemens, Suisstec) 
? Evaluation PepLink (sichere Mobilfunk-Verbindung für Mig-
ration und Folgebetrieb für abgelegene Standorte) 
? HW Test im Labor (inkl. Firewall-Routing, PepLink) 
? Migrationsetappen definieren und begründen (Terminpla-
nung und Priorisierung) 
? Validation Migrationsplanung durch SCRT ', CAST(N'2020-02-28' AS Date), CAST(N'2020-07-31' AS Date), 10, 10, 0, 0, 0, 5, 0.5, NULL, N'Gemäss IT-Board vom 18.05.2020 wurde entschieden das Projekt auf ende Juli zu verschieben')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (105, 7, 11, 1, 1, 7, 1, N'Enrôlement des smartphones', N' Actuellement, seuls les iPhones qui doivent pouvoir utiliser CareOf-
fice sont enrôlés dans notre outil MDM (mobile device manage-
ment) Workspace One (ancien nom d’Airwatch). 
L’objectif est d’enrôler tous les iPhones dans Workspace One. Tous 
les collaborateurs qui possèdent un iPhone doivent passer à l’IT 
pour enrôler leur smartphone. 
Certains anciens iPhones encore en service (4 / 5 / 6 / SE) seront 
remplacés par des appareils plus récents. ', CAST(N'2020-02-28' AS Date), CAST(N'2020-07-31' AS Date), 40, 40, 0, 0, 0, 0, 0, NULL, N'Gemäss Entscheid IT-Board vom 20.04.2020 wird das Projekt bis Ende Juli verlängert werden.')
INSERT [dbo].[Projects] ([ID_Project], [CE_ID_Status], [CE_ID_ProjectManager], [CE_ID_Priority], [CE_ID_Category], [CE_ID_Customer], [CE_ID_Urgency], [Title], [Description], [BeginDate], [Deadline], [EstimatedResources], [EstimatedResourcesInfra], [EstimatedResourcesSAP], [EstimatedResourcesHelpdesk], [EstimatedResourcesPlaning], [ImplementationRate], [EffectiveResources], [HideInWebPage], [Text_IT_Board]) VALUES (106, 8, 1, 2, 5, 7, 2, N'iTOP: Migration & Ticketing  - 46000296', N'Pour remplacer le Helpdesk de IT (Programme maison)
-Migration sur Windows 2016, mise en place du système ticketing,
maintenance annuelle', CAST(N'2020-03-19' AS Date), CAST(N'2020-07-31' AS Date), 16, 6, 0, 10, 0, 0, 0, NULL, N'')
