DOXY_EXEC_PATH = C:/Users/Dom-1/Desktop/WindowsFormsApp2_prawiegotowe_bez_historii/WindowsFormsApp2
DOXYFILE = C:/Users/Dom-1/Desktop/WindowsFormsApp2_prawiegotowe_bez_historii/WindowsFormsApp2/-
DOXYDOCS_PM = C:/Users/Dom-1/Desktop/WindowsFormsApp2_prawiegotowe_bez_historii/WindowsFormsApp2/perlmod/DoxyDocs.pm
DOXYSTRUCTURE_PM = C:/Users/Dom-1/Desktop/WindowsFormsApp2_prawiegotowe_bez_historii/WindowsFormsApp2/perlmod/DoxyStructure.pm
DOXYRULES = C:/Users/Dom-1/Desktop/WindowsFormsApp2_prawiegotowe_bez_historii/WindowsFormsApp2/perlmod/doxyrules.make

.PHONY: clean-perlmod
clean-perlmod::
	rm -f $(DOXYSTRUCTURE_PM) \
	$(DOXYDOCS_PM)

$(DOXYRULES) \
$(DOXYMAKEFILE) \
$(DOXYSTRUCTURE_PM) \
$(DOXYDOCS_PM): \
	$(DOXYFILE)
	cd $(DOXY_EXEC_PATH) ; doxygen "$<"
