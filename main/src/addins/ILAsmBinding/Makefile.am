
ADDIN_BUILD = $(top_builddir)/build/AddIns/BackendBindings
ASSEMBLY = $(ADDIN_BUILD)/ILAsmBinding.dll

DEPS =  \
	$(top_builddir)/build/bin/MonoDevelop.Core.dll \
	$(top_builddir)/build/bin/MonoDevelop.Ide.dll

REFS =  \
	$(GLIB_SHARP_LIBS) \
	$(GTK_SHARP_LIBS) \
	$(MONO_ADDINS_LIBS) \
	-r:Mono.Posix \
	-r:System \
	-r:System.Xml

FILES =  \
	AssemblyInfo.cs \
	gtk-gui/generated.cs \
	gtk-gui/ILAsmBinding.CompilerParametersPanelWidget.cs \
	Gui/CompilerParametersPanelWidget.cs \
	ILAsmCompilerManager.cs \
	ILAsmLanguageBinding.cs \
	Project/ILAsmCompilerParameters.cs

RES =  \
	gtk-gui/gui.stetic \
	ILAsmBinding.addin.xml \
	ILAsmConsoleProject.xpt.xml


assemblydir = $(MD_ADDIN_DIR)/BackendBindings
assembly_DATA = $(ASSEMBLY) $(ASSEMBLY).mdb

all: $(ASSEMBLY) $(ASSEMBLY).mdb

$(ASSEMBLY): $(build_sources) $(build_resources) $(DEPS)
	mkdir -p $(ADDIN_BUILD)
	$(CSC) $(CSC_FLAGS) $(build_resources:%=/resource:%) $(build_sources) $(REFS) $(build_deps) -out:$@ -target:library

$(ASSEMBLY).mdb: $(ASSEMBLY)

CLEANFILES = $(ASSEMBLY) $(ASSEMBLY).mdb
EXTRA_DIST = $(FILES) $(RES)
include $(top_srcdir)/Makefile.include

