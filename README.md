# 🌍 Project 31 — World Explorer

> A multi-form C# desktop encyclopedia — 7 continent screens accessible through an interactive world map, hover tooltips, and text search. First multi-form project in the WinForms practice series.

---

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/d66bade9-bb1b-47ed-b4e1-1b24f1575bab" />

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/d9ac2cae-a43a-4e9e-a9bb-85c97496c01b" />

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/17d829db-39af-4adc-b6c5-8c2baa6b1759" />

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/4e0a3ec4-a618-4922-b905-0bc4cedad747" />

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/13384d38-cca0-46e1-9030-e99da7ef910c" />

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/37f46fad-9972-4f13-a795-dace31875548" />

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/a95bb075-dc25-4d2b-90c4-22b29f876708" />

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/10986216-38d5-43ee-9c19-9ab8fe4bc136" />

<img width="356" height="235" alt="image" src="https://github.com/user-attachments/assets/ee58836e-785a-4aab-9ab7-ff89cd7fa838" />


---

## 🚀 Project Overview

Seventh project in the WinForms self-practice series.

And the most complex one so far.

Not one form. Not two.

Nine forms working together.

A Start Screen with a world map and two buttons.

A Main Screen where seven continent buttons sit on top of a world map image — click one and it opens a dedicated continent screen.

Seven continent information screens — each with photos, a globe image, and structured facts about population, languages, landmarks, and area.

One search box on the main screen accepts a continent name, finds the right screen, and opens it.

One confirm dialog before the app closes — with Cancel as the default button, so an accidental Enter press never closes the program.

---

## 🏗️ Architecture Design

```
Application.Run(frmStartScreen)
 ├── [Start] → new frmMainScreen().Show()
 └── [Exit]  → ShowConfirmExitMessageBox()
                └── DialogResult.OK → this.Close()

frmMainScreen
 ├── PictureBox (world map — background layer)
 ├── 7 continent Buttons (positioned ON the map)
 │    ├── MouseEnter → lblContinent.Text = btn.Tag (continent name)
 │    ├── MouseLeave → lblContinent.Text = "?"
 │    └── Click → Show[Continent]Screen()
 └── [Search TextBox + Search Button]
      └── txtSearch.Text.ToLower()
           └── switch → Show[Continent]Screen() OR MessageBox Error

frmAfricaScreen / frmAsiaScreen / frmEuropeScreen /
frmAustraliaScreen / frmAntarcticaScreen /
frmNorthAmericaScreen / frmSouthAmericaScreen
 ├── Title Label
 ├── PictureBox (hero landscape image)
 ├── PictureBox (continent globe)
 ├── PictureBox × 3 (landmark photos)
 └── Labels (Population · Languages · Landmarks · Area)
```

---

## ⚙️ Core Functionalities

| Screen | Feature |
|---|---|
| **Start Screen** | World map image, Start button, Exit with confirm dialog |
| **Main Screen** | 7 continent buttons on interactive map, hover tooltip label, text search |
| **7 Continent Screens** | Hero image, globe, 3 landmark photos, structured info |

---

## 🧠 Design Decisions Worth Noting

### Interactive map without a map control

There is no map library, no mapping component, no GIS control.

The interactive map is a `PictureBox` showing a world map image.

The continent buttons are regular WinForms `Button` controls positioned on top of it — placed at the coordinates where each continent sits on the image.

Hovering over a button changes a label to that continent's name.

Clicking opens the continent's form.

The same effect as an interactive map. Built with only labels, buttons, and a PictureBox.

---

### Hover tooltip via MouseEnter and MouseLeave

```csharp
private void btn_MouseEnter(object sender, EventArgs e)
{
    lblContinent.Text = ((Button)sender).Tag.ToString();
}

private void btn_MouseLeave(object sender, EventArgs e)
{
    lblContinent.Text = "?";
}
```

Both events share one handler per event type.

Enter → show the continent name. Leave → reset to "?".

No external tooltip control needed.

---

### Confirm exit with Cancel as default

```csharp
MessageBox.Show(
    "Are You Sure You Want To Exit The Program ?",
    "Confirm!",
    MessageBoxButtons.OKCancel,
    MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button2   // ← Cancel is default
);
```

`MessageBoxDefaultButton.Button2` makes Cancel the pre-selected button.

Pressing Enter by accident does nothing — the user must actively click OK.

Small detail. Real UX thinking.

---

### Case-insensitive search

```csharp
private void Search()
{
    switch (txtSearch.Text.ToLower())
    {
        case "africa": ShowAfricaScreen(); break;
        case "asia":   ShowAsiaScreen();   break;
        // ...
        default:       ShowSearchErrorMessageBox(); break;
    }
}
```

`ToLower()` before the switch — so "ASIA", "Asia", "asia" all work.

---

### Tag-based shared handler — consistent pattern

Same approach used throughout the practice series:

```csharp
private void btn_Click(object sender, EventArgs e)
{
    switch (((Button)sender).Tag)
    {
        case "Africa": ShowAfricaScreen(); break;
        case "Asia":   ShowAsiaScreen();   break;
        // ...
        case "Search": Search();           break;
    }
}
```

One handler. All buttons. Tags carry the instruction.

---

## 🆕 New Controls in This Project

| Control | First used here | Purpose |
|---|---|---|
| **PictureBox** | ✅ Yes | World map, continent globe, landmark photos |
| **MessageBox** | ✅ Yes | Error alert, confirm exit dialog |
| Multiple Forms | ✅ Yes | Start screen + main hub + 7 continent screens |
| MouseEnter / MouseLeave | ✅ Yes | Hover tooltip on map buttons |

---

## 🛠️ Tech Stack

| | |
|---|---|
| **Language** | C# |
| **Framework** | .NET Framework 4.8 |
| **UI** | Windows Forms (WinForms) |
| **IDE** | Visual Studio |
| **Type** | Desktop Application — Multi-Form |
| **Controls Used** | Form · Label · TextBox · Button · PictureBox · MessageBox |

---

## 📦 Practice Project Series

| Project | Application |
|---|---|
| **Project 25 — Tax Calculator** | Tax computation + session history |
| **Project 26 — Text Encryption** | Caesar Cipher encrypt/decrypt |
| **Project 27 — Password Generator** | GUID + Key + Password generator |
| **Project 28 — Age Calculator** | Full age breakdown with time lived |
| **Project 29 — String Manipulation** | Live string operations toolkit |
| **Project 30 — Simple Calculator** | Full calculator with theme toggle |
| **Project 31 — World Explorer** *(you are here)* | Multi-form geography encyclopedia |
| More projects | Next control groups 🔄 |

---

## 🏁 Course & Milestone Context

- ✅ Course 14 — C# Level 1 (Stage Two, in progress)
- ✅ Seventh project in the WinForms self-practice series
- ✅ First multi-form application in the series
- ✅ First use of PictureBox, MessageBox, and MouseEnter/Leave events
- ✅ Part of the **Programming Advices Roadmap** — Stage Two

---

## 🙏 Gratitude

Thank you to:

**[Programming Advices Platform](https://programmingadvices.com)**

**[Dr. Mohammed Abu-Hadhoud](https://programmingadvices.com)**

---

## 🔥 What's Next

Next control group.

Next project.
