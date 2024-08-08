import type { Metadata } from "next";
import "./globals.css";

export const metadata: Metadata = {
  title: "E2E Type-safe .NET to TypeScript",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body>{children}</body>
    </html>
  );
}
